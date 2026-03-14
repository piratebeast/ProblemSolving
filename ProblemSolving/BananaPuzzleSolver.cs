using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ProblemSolving
{
    public class BananaPuzzleSolver
    {
        public double Solve(double totalBanaga, double capacity, double totalDistance, int consumtationRate)
        {
            var currentBanana = totalBanaga;
            var currentDistance = 0.0;

            while (currentBanana > capacity)
            {
                var numLoads = Math.Ceiling(currentBanana / capacity);

                var numTrips = numLoads * 2 - 1;

                var rateForStage = numTrips * consumtationRate;

                var bananaToSpend = currentBanana - (numLoads - 1) * capacity;

                var maxDistanceThisStage = bananaToSpend / rateForStage;

                var distanceRemainingToMarket = totalDistance - currentDistance;

                if (maxDistanceThisStage >= distanceRemainingToMarket)
                {
                    double bananasEaten = distanceRemainingToMarket * rateForStage;
                    currentBanana -= bananasEaten;
                    currentDistance += distanceRemainingToMarket;

                    break;
                }
                else
                {
                    currentBanana -= bananaToSpend;
                    currentDistance += maxDistanceThisStage;
                }
            }

            if (currentDistance >= totalDistance)
            {
                return Math.Max(0, currentBanana);
            }

            double finalDistance = totalDistance - currentDistance;
            double finalBananasEaten = finalDistance * consumtationRate;
            double bananaDelivered = currentBanana - finalBananasEaten;

            return Math.Max(0, bananaDelivered);
        }
    }
}
