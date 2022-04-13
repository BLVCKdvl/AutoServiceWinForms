using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServicewinForms.model
{
    public class WorkType
    {
        public string workName;
        private decimal cost; 

        public void SetCost(decimal cost)
        {
            this.cost = (cost >= 0) ? cost : 0;
        }

        public decimal GetCost()
        {
            return cost;
        }

        public WorkType() { }

        public WorkType(string workName, decimal cost) 
        {
            this.workName = workName;
            SetCost(cost);
        }

        public override string ToString()
        {
            return $"\t* {workName} -- {cost}";
        }
    }
}
