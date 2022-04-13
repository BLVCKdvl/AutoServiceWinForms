using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServicewinForms.model
{
    public class CostCalculator
    {

        public static decimal CalculateCost(WorkCollection workCollection)
        {
            decimal cost = 0;
            foreach (var item in workCollection.GetCollection())
            {
                cost += item.GetCost();
            }

            return cost;
        }
    }
}
