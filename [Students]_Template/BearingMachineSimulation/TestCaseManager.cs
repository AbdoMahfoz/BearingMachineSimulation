using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Collections.Generic;
using BearingMachineModels;
using BearingMachineSimulation;
using BearingMachineTesting;

namespace BearingMachineSimulation
{
    /// <summary>
    /// Handles reading and writing from test case files
    /// </summary>
    static class TestCaseManager
    {
        class Header
        {
            public string Name;
            public bool IsSingleLine = true, IsOneArgument = true;
            public Action<SimulationSystem, string[]> Input;
            public Action<SimulationSystem, StringBuilder> Output;
        }
        static readonly List<Header> Headers = new List<Header>()
        {
            new Header()
            {
                Name = "DowntimeCost",
                Input = (SimulationSystem s, string[] val) =>
                {
                    s.DowntimeCost = int.Parse(val[0]);
                },
                Output = (SimulationSystem s, StringBuilder b) =>
                {
                    b.AppendLine(s.DowntimeCost.ToString());
                }
            },
            new Header()
            {
                Name = "RepairPersonCost",
                Input = (SimulationSystem s, string[] val) =>
                {
                    s.RepairPersonCost = int.Parse(val[0]);
                },
                Output = (SimulationSystem s, StringBuilder b) =>
                {
                    b.AppendLine(s.RepairPersonCost.ToString());
                }
            },
            new Header()
            {
                Name = "BearingCost",
                Input = (SimulationSystem s, string[] val) =>
                {
                    s.BearingCost = int.Parse(val[0]);
                },
                Output = (SimulationSystem s, StringBuilder b) =>
                {
                    b.AppendLine(s.BearingCost.ToString());
                }
            },
            new Header()
            {
                Name = "NumberOfHours",
                Input = (SimulationSystem s, string[] val) =>
                {
                    s.NumberOfHours = int.Parse(val[0]);
                },
                Output = (SimulationSystem s, StringBuilder b) =>
                {
                    b.AppendLine(s.NumberOfHours.ToString());
                }
            },
            new Header()
            {
                Name = "NumberOfBearings",
                Input = (SimulationSystem s, string[] val) =>
                {
                    s.NumberOfBearings = int.Parse(val[0]);
                },
                Output = (SimulationSystem s, StringBuilder b) =>
                {
                    b.AppendLine(s.NumberOfBearings.ToString());
                }
            },
            new Header()
            {
                Name = "RepairTimeForOneBearing",
                Input = (SimulationSystem s, string[] val) =>
                {
                    s.RepairTimeForOneBearing = int.Parse(val[0]);
                },
                Output = (SimulationSystem s, StringBuilder b) =>
                {
                    b.AppendLine(s.RepairTimeForOneBearing.ToString());
                }
            },
            new Header()
            {
                Name = "RepairTimeForAllBearings",
                Input = (SimulationSystem s, string[] val) =>
                {
                    s.RepairTimeForAllBearings = int.Parse(val[0]);
                },
                Output = (SimulationSystem s, StringBuilder b) =>
                {
                    b.AppendLine(s.RepairTimeForAllBearings.ToString());
                }
            },
            new Header()
            {
                Name = "DelayTimeDistribution",
                IsSingleLine = false,
                IsOneArgument = false,
                Input = (SimulationSystem s, string[] val) =>
                {
                    foreach(string line in val)
                    {
                        decimal[] nums = Array.ConvertAll(line.Split(','), decimal.Parse);
                        s.DelayTimeDistribution.Add(new TimeDistribution()
                        {
                            Time = (int)nums[0],
                            Probability = nums[1]
                        });
                    }
                },
                Output = (SimulationSystem s, StringBuilder b) =>
                {
                    foreach(TimeDistribution distribution in s.DelayTimeDistribution)
                    {
                        b.AppendLine(distribution.Time.ToString() + ", " + distribution.Probability.ToString());
                    }
                }
            },
            new Header()
            {
                Name = "BearingLifeDistribution",
                IsSingleLine = false,
                IsOneArgument = false,
                Input = (SimulationSystem s, string[] val) =>
                {
                    foreach(string line in val)
                    {
                        decimal[] nums = Array.ConvertAll(line.Split(','), decimal.Parse);
                        s.BearingLifeDistribution.Add(new TimeDistribution()
                        {
                            Time = (int)nums[0],
                            Probability = nums[1]
                        });
                    }
                },
                Output = (SimulationSystem s, StringBuilder b) =>
                {
                    foreach(TimeDistribution distribution in s.BearingLifeDistribution)
                    {
                        b.AppendLine(distribution.Time.ToString() + ", " + distribution.Probability.ToString());
                    }
                }
            }
        };
        /// <summary>
        /// Extracts simulation system out of a file
        /// </summary>
        /// <param name="path">path to simulation system file</param>
        static public SimulationSystem FromFile(string path)
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            SimulationSystem system = new SimulationSystem();
            while (reader.Peek() != -1)
            {
                string header = reader.ReadLine().Trim();
                bool HeaderFound = false;
                foreach(Header h in Headers)
                {
                    if(h.Name == header)
                    {
                        HeaderFound = true;
                        List<string> lines = new List<string>();
                        string s;
                        while(!string.IsNullOrWhiteSpace(s = reader.ReadLine()))
                        {
                            s.Trim();
                            if(s.Split(',').Length > 1 && h.IsOneArgument)
                            {
                                throw new FormatException("Header \"" + header + "\" expects only a single argument per line, receieved " + lines.Count + " arguments");
                            }
                            lines.Add(s);
                        }
                        if(h.IsSingleLine && lines.Count > 1)
                        {
                            throw new FormatException("Header \"" + header + "\" expects only a single line, receieved " + lines.Count + " lines");
                        }
                        h.Input(system, lines.ToArray());
                        break;
                    }
                }
                if(!HeaderFound)
                {
                    throw new ArgumentException("Header \"" + header + "\" is not defined");
                }
            }
            reader.Close();
            return system;
        }
        /// <summary>
        /// Writes the simulation system to a string
        /// </summary>
        /// <param name="system">The simulation system to be written</param>
        static public string ToString(SimulationSystem system)
        {
            StringBuilder builder = new StringBuilder();
            foreach(Header header in Headers)
            {
                builder.AppendLine(header.Name);
                header.Output(system, builder);
                builder.AppendLine();
            }
            return builder.ToString().Trim();
        }
        /// <summary>
        /// Writes a simulation system to a file. if the file exists it will be overwritten, otherwise it will be created
        /// </summary>
        /// <param name="system">The simulation system to be written</param>
        /// <param name="path">path to file</param>
        static public void ToFile(SimulationSystem system, string path)
        {
            FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            writer.Write(ToString(system));
            writer.Close();
        }
        /// <summary>
        /// Runs all test cases in TestCases folder
        /// </summary>
        /// <returns>Result of running all of the testcases</returns>
        static public string RunAllTestCases()
        {
            string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()) + "\\TestCases\\";
            StringBuilder builder = new StringBuilder();
            Stopwatch watch = new Stopwatch();
            int i = 1;
            foreach (string file in Directory.EnumerateFiles(path))
            {
                string fileName = file.Substring(file.LastIndexOf('\\') + 1);
                if (fileName.Contains("TestCase"))
                {
                    builder.AppendLine("---TestCase #" + i++);
                    SimulationSystem system = FromFile(file);
                    watch.Restart();
                    Simulator.CurrrentCalculateCase(system);
                    Simulator.ProposedCalculateCase(system);
                    watch.Stop();
                    builder.AppendLine(TestingManager.Test(system, fileName)
                                     + "\nTime = " + watch.ElapsedMilliseconds + "ms");
                }
            }
            return builder.ToString().Trim();
        }
    }
}