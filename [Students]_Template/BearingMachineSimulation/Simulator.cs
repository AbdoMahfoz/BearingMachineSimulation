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
        /// <param name="Case"></param>
        /// <param name="system"></param>
        static void CalculateCase(CurrentSimulationCase Case, SimulationSystem system)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Case"></param>
        /// <param name="system"></param>
        /// <param name="CurrentCases"></param>
        static void CalculateCase(ProposedSimulationCase Case, SimulationSystem system, params CurrentSimulationCase[] CurrentCases)
        {
            throw new NotImplementedException();
        }
    }
}
