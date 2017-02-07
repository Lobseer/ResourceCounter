using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project2Resurses
{
    public class Controller
    {
        private const int RES_GEN_INTERVAL = 3;

        private Resource resource;
        private bool enabled;
        private double count;

        private DateTime startDate;

        public string ResourceName
        {
            get
            {
                return resource.Name;
            }
        }

        public double Count
        {
            get
            {
                return count;
            }
        }

        public double TotalCost
        {
            get
            {
                return count * resource.Cost;
            }
        }

        public bool Enabled
        {
            get
            {
                lock (runLock) { return enabled; }
            }
            set
            {
                lock (runLock) { enabled = value; }
            }
        }

        internal Resource CountingResource
        {
            get
            {
                return resource;
            }

            set
            {
                resource = value;
            }
        }

        public Controller(Resource res)
        {
            this.resource = res;
            this.Enabled = false;
            this.count = 0;
        }

        public void On()
        {
            Enabled = true;
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Run));      
        }

        public void Off()
        {
            Enabled = false;
        }

        void Run(object o)
        {
            Random rnd = new Random();
            while(Enabled)
            {              
                count += rnd.NextDouble() * rnd.Next(100);
                Thread.Sleep(1000 * RES_GEN_INTERVAL);
            }
        }

        public override string ToString()
        {
            string result = $"Enabled: {enabled}; Resource: {ResourceName}; Count: {Count}; Total Cost: {TotalCost}";

            return result;
        }
    }
}
