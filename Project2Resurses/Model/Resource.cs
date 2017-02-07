using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project2Resurses
{
    public class Resource
    {
        private string name;

        private double cost;
        private DateTime rateAdoptDate;

        public Resource(string name, double nowCost)
        {
            this.name = name;
            this.cost = nowCost;
            this.rateAdoptDate = DateTime.Now;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double Cost
        {
            get
            {
                return cost;
            }

            set
            {
                if (value > 0)
                {
                    cost = value;
                    rateAdoptDate = DateTime.Now;
                }
            }
        }

        public DateTime RateAdoptDate
        {
            get
            {
                return rateAdoptDate;
            }
        }
        public override string ToString()
        {
            return $"{name}: {cost}";
        }
    }
}
