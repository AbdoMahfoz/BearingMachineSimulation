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
        static int totalDelayP= 0;
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
           for(int i =0; i<system.NumberOfBearings;i++)
            {
                int j = 0;
                while(true)
                {
                    system.CurrentSimulationTable[j].Bearing.Index = i;
                    system.CurrentSimulationTable[j].Bearing.RandomHours = random.Next(1, 100);
                    system.CurrentSimulationTable[j].Bearing.Hours = CalculateRandomValue(system.BearingLifeDistribution, system.CurrentSimulationTable[j].Bearing.RandomHours);
                    system.CurrentSimulationTable[j].RandomDelay = random.Next(1, 10);
                    system.CurrentSimulationTable[j].Delay = CalculateRandomValue(system.DelayTimeDistribution, system.CurrentSimulationTable[j].RandomDelay);
                    if (j == 0)
                    {
                        system.CurrentSimulationTable[j].AccumulatedHours = system.CurrentSimulationTable[j].Bearing.Hours;
                    }
                    else
                    {
                        system.CurrentSimulationTable[j].AccumulatedHours = system.CurrentSimulationTable[j - 1].AccumulatedHours + system.CurrentSimulationTable[j].Bearing.Hours;
                    }
                    totalDelayC += system.CurrentSimulationTable[j].Delay;
                    system.CurrentPerformanceMeasures.BearingCost += system.BearingCost;
                    system.CurrentPerformanceMeasures.DelayCost += system.CurrentSimulationTable[j].Delay * system.DowntimeCost;
                    system.CurrentPerformanceMeasures.DowntimeCost = system.CurrentSimulationTable[j].Bearing.Index * system.RepairTimeForOneBearing * system.DowntimeCost;
                    system.CurrentPerformanceMeasures.RepairPersonCost = system.CurrentSimulationTable[j].Bearing.Index * system.RepairTimeForOneBearing * (system.RepairPersonCost / 60);
                    system.CurrentPerformanceMeasures.TotalCost +=
                    system.CurrentPerformanceMeasures.BearingCost + system.CurrentPerformanceMeasures.DelayCost + system.CurrentPerformanceMeasures.DowntimeCost + system.CurrentPerformanceMeasures.RepairPersonCost;
                    system.CurrentSimulationTable.Add(system.CurrentSimulationTable[j]);
                    if (system.CurrentSimulationTable[j].AccumulatedHours >= system.NumberOfHours)
                        break;
                    j++;
                }
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="system"></param>
        static public void ProposedCalculateCase(SimulationSystem system)
        {
            int i = 0;
            int k = 0;
            while (true)
            {
                //ProposedSimulationCase Case = new ProposedSimulationCase();
                int min = system.NumberOfHours;
                for (int j = 0; j < system.NumberOfBearings; j++)
                {
                    if(system.CurrentSimulationTable[k].Bearing == null)
                    {
                        Bearing bearing = new Bearing();
                        bearing.Index = j;
                        bearing.RandomHours = random.Next(1, 100);
                        bearing.Hours = CalculateRandomValue(system.BearingLifeDistribution, bearing.RandomHours);
                    }
                    else
                        system.ProposedSimulationTable[i].Bearings[j] = system.CurrentSimulationTable[k].Bearing;
                    if (system.ProposedSimulationTable[i].Bearings[j].Hours < min)
                    {
                        min = system.ProposedSimulationTable[i].Bearings[j].Hours;
                    }
                    k++;
                }
                system.ProposedSimulationTable[i].FirstFailure = min;
                if(i==0)
                {
                    system.ProposedSimulationTable[i].AccumulatedHours = min;
                }
                else
                {
                    system.ProposedSimulationTable[i].AccumulatedHours = system.ProposedSimulationTable[i-1].AccumulatedHours+min;
                }
                system.ProposedSimulationTable[i].RandomDelay = random.Next(1, 10);
                system.ProposedSimulationTable[i].Delay = CalculateRandomValue(system.DelayTimeDistribution, system.ProposedSimulationTable[i].RandomDelay);
                //system.ProposedSimulationTable.Add(Case);
                totalDelayP += system.ProposedSimulationTable[i].Delay;
                system.ProposedPerformanceMeasures.BearingCost += system.NumberOfBearings * system.BearingCost;
                system.ProposedPerformanceMeasures.DelayCost += system.ProposedSimulationTable[i].Delay* system.DowntimeCost;
                system.ProposedPerformanceMeasures.DowntimeCost += system.DowntimeCost * system.RepairTimeForAllBearings;
                system.ProposedPerformanceMeasures.RepairPersonCost += system.RepairTimeForAllBearings * (system.RepairPersonCost / 60);
                system.ProposedPerformanceMeasures.TotalCost += system.ProposedPerformanceMeasures.BearingCost + system.ProposedPerformanceMeasures.DelayCost + system.ProposedPerformanceMeasures.DowntimeCost + system.ProposedPerformanceMeasures.RepairPersonCost;
                if (system.ProposedSimulationTable[i].AccumulatedHours >= system.NumberOfHours)
                    break;
                i++;
            }
        }
    }
}
