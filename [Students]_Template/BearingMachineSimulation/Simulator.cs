using System;
using System.Collections.Generic;
using BearingMachineModels;

namespace BearingMachineSimulation
{
    /// <summary>
    /// 
    /// </summary>
    static class Simulator
    {
        static Random random = new Random();
        static int totalDelayC = 0;
        static int totalDelayP = 0;
        /// <summary>
        /// Extract the random value out of a TimeDistribution object using a given random variable
        /// </summary>
        /// <param name="Distribution">Used to evaluate final random value</param>
        /// <param name="RandomVariable">The random number required by TimeDistribution parameter</param>
        /// <returns>The requested random value</returns>
        static private int CalculateRandomValue(List<TimeDistribution> Distribution, int RandomVariable)
        {
            for (int i = 0; i < Distribution.Count; i++)
            {
                if (!Distribution[i].IsCalculated)
                {
                    if (i == 0)
                    {
                        Distribution[i].CummProbability = Distribution[i].Probability;
                        Distribution[i].MinRange = 1;
                    }
                    else
                    {
                        Distribution[i].CummProbability = Distribution[i].Probability + Distribution[i - 1].CummProbability;
                        Distribution[i].MinRange = Distribution[i - 1].MaxRange + 1;
                    }
                    Distribution[i].MaxRange = (int)(Distribution[i].CummProbability * 100);
                    Distribution[i].IsCalculated = true;
                }
                if (RandomVariable <= Distribution[i].MaxRange && RandomVariable >= Distribution[i].MinRange)
                {
                    return Distribution[i].Time;
                }
            }
            if (RandomVariable < 1 || RandomVariable > 100)
                throw new ArgumentOutOfRangeException("RandomValue should be between 1 and 100");
            else
                throw new Exception("Debug meeeeeeeee");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="system"></param>
        static public void CurrrentCalculateCase(SimulationSystem system)
        {
            int j = -1;
            for (int i = 0; i < system.NumberOfBearings; i++)
            {
                bool first = true;
                while (true)
                {
                    j++;
                    system.CurrentSimulationTable.Add(new CurrentSimulationCase());
                    system.CurrentSimulationTable[j].Bearing.Index = i;
                    system.CurrentSimulationTable[j].Bearing.RandomHours = random.Next(1, 100);
                    system.CurrentSimulationTable[j].Bearing.Hours = CalculateRandomValue(system.BearingLifeDistribution, system.CurrentSimulationTable[j].Bearing.RandomHours);
                    system.CurrentSimulationTable[j].RandomDelay = random.Next(1, 100);
                    system.CurrentSimulationTable[j].Delay = CalculateRandomValue(system.DelayTimeDistribution, system.CurrentSimulationTable[j].RandomDelay);
                    if (first)
                    {
                        first = false;
                        system.CurrentSimulationTable[j].AccumulatedHours = system.CurrentSimulationTable[j].Bearing.Hours;
                    }
                    else
                    {
                        system.CurrentSimulationTable[j].AccumulatedHours = system.CurrentSimulationTable[j - 1].AccumulatedHours + system.CurrentSimulationTable[j].Bearing.Hours;
                    }
                    totalDelayC += system.CurrentSimulationTable[j].Delay;
                    system.CurrentPerformanceMeasures.BearingCost += system.BearingCost;
                    system.CurrentPerformanceMeasures.DelayCost += system.CurrentSimulationTable[j].Delay * system.DowntimeCost;
                    system.CurrentPerformanceMeasures.DowntimeCost += system.RepairTimeForOneBearing * system.DowntimeCost;
                    system.CurrentPerformanceMeasures.RepairPersonCost += system.RepairTimeForOneBearing * (system.RepairPersonCost / (decimal)60);
                    //system.CurrentSimulationTable.Add(system.CurrentSimulationTable[j]);
                    if (system.CurrentSimulationTable[j].AccumulatedHours >= system.NumberOfHours)
                    {
                        break;
                    }
                }
            }
            system.CurrentPerformanceMeasures.TotalCost =
                    system.CurrentPerformanceMeasures.BearingCost + system.CurrentPerformanceMeasures.DelayCost
                  + system.CurrentPerformanceMeasures.DowntimeCost + system.CurrentPerformanceMeasures.RepairPersonCost;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="system"></param>
        static public void ProposedCalculateCase(SimulationSystem system)
        {
            int iP = 0;
            int i = 0;
            int h = 0;
            int num = 0;
            int LastBearingsIndex = 0;
            while (i < system.CurrentSimulationTable.Count)
            {
                if(LastBearingsIndex != system.CurrentSimulationTable[i].Bearing.Index)
                {
                    LastBearingsIndex++;
                    h = 0;
                }
                if (h >= system.ProposedSimulationTable.Count)
                {
                    system.ProposedSimulationTable.Add(new ProposedSimulationCase()
                    {
                        Bearings = new List<Bearing>()
                    });
                    for (int k = 0; k < system.NumberOfBearings; k++)
                    {
                        system.ProposedSimulationTable[h].Bearings.Add(null);
                    }
                }
                if (num != system.CurrentSimulationTable[i].Bearing.Index)
                {
                    iP = 0;
                    num = system.CurrentSimulationTable[i].Bearing.Index;
                }
                system.ProposedSimulationTable[h].Bearings[num] = system.CurrentSimulationTable[i].Bearing;
                iP++;
                i++;
                h++;
            }
            i = 0;
            while (true)
            {
                int min = system.NumberOfHours;
                if (i >= system.ProposedSimulationTable.Count)
                {
                    system.ProposedSimulationTable.Add(new ProposedSimulationCase()
                    {
                        Bearings = new List<Bearing>()
                    });
                    for (int k = 0; k < system.NumberOfBearings; k++)
                    {
                        system.ProposedSimulationTable[i].Bearings.Add(null);
                    }
                }
                for (int j = 0; j < system.NumberOfBearings; j++)
                {
                    if (i >= system.CurrentSimulationTable.Count)
                    {
                        system.CurrentSimulationTable.Add(new CurrentSimulationCase());
                    }
                    if (system.ProposedSimulationTable[i].Bearings[j] == null)
                    {
                        Bearing bearing = new Bearing
                        {
                            Index = j,
                            RandomHours = random.Next(1, 100)
                        };
                        bearing.Hours = CalculateRandomValue(system.BearingLifeDistribution, bearing.RandomHours);
                        system.ProposedSimulationTable[i].Bearings[j] = bearing;
                    }
                    if (system.ProposedSimulationTable[i].Bearings[j].Hours < min)
                    {
                        min = system.ProposedSimulationTable[i].Bearings[j].Hours;
                    }
                }
                system.ProposedSimulationTable[i].FirstFailure = min;
                if (i == 0)
                {
                    system.ProposedSimulationTable[i].AccumulatedHours = min;
                }
                else
                {
                    system.ProposedSimulationTable[i].AccumulatedHours = system.ProposedSimulationTable[i - 1].AccumulatedHours + min;
                }
                system.ProposedSimulationTable[i].RandomDelay = random.Next(1, 10);
                system.ProposedSimulationTable[i].Delay = CalculateRandomValue(system.DelayTimeDistribution, system.ProposedSimulationTable[i].RandomDelay);
                totalDelayP += system.ProposedSimulationTable[i].Delay;
                system.ProposedPerformanceMeasures.BearingCost += system.NumberOfBearings * system.BearingCost;
                system.ProposedPerformanceMeasures.DelayCost += system.ProposedSimulationTable[i].Delay * system.DowntimeCost;
                system.ProposedPerformanceMeasures.DowntimeCost += system.DowntimeCost * system.RepairTimeForAllBearings;
                system.ProposedPerformanceMeasures.RepairPersonCost += system.RepairTimeForAllBearings * (system.RepairPersonCost / (decimal)60);
                if (system.ProposedSimulationTable[i].AccumulatedHours >= system.NumberOfHours)
                    break;
                i++;
            }
            system.ProposedPerformanceMeasures.TotalCost = system.ProposedPerformanceMeasures.BearingCost + system.ProposedPerformanceMeasures.DelayCost + system.ProposedPerformanceMeasures.DowntimeCost + system.ProposedPerformanceMeasures.RepairPersonCost;
        }
    }
}
