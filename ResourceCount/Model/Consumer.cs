using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Resurses
{
    class ConsumerPerson : IConsumer
    {
        private string name;

        private List<Controller> controllers = new List<Controller>();

        public ConsumerPerson(string name)
        {
            this.name = name;
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

        public string Type
        {
            get
            {
                return this.GetType().Name;
            }
        }

        public List<Controller> Controllers
        {
            get { return controllers; }
        }

        public bool hasController(string resourceName)
        {
            return controllers.Any((p) => p.ResourceName == resourceName);
        }

        public double ConsumedResource(string recourceName)
        {
            return controllers.FirstOrDefault((p) => p.ResourceName == recourceName).Count;
        }

        public double ConsumedResourceOverTime(string recourceName, DateTime start, DateTime finish)
        {
            throw new NotImplementedException();
        }

        public bool AddNewController(Resource res)
        {
            if (controllers.Any((p) => p.ResourceName == res.Name)) return false;
            controllers.Add(new Controller(res));
            return true;
        }

        public bool DeleteController(int id)
        {
            throw new NotImplementedException();
        }
    }

    class ConsumerCompany : IConsumer
    {
        private string name;

        private List<Controller> controllers = new List<Controller>();
        private Dictionary<string, List<Controller>> co = new Dictionary<string, List<Controller>>();

        public ConsumerCompany(string name)
        {
            this.name = name;
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

        public string Type
        {
            get
            {
                return this.GetType().Name;
            }
        }

        public List<Controller> Controllers
        {
            get { return controllers; }
        }

        public bool hasController(string resourceName)
        {
            return controllers.Any((p) => p.ResourceName == resourceName);
        }

        public double ConsumedResource(string recourceName)
        {
            double result = 0;
            foreach(Controller ctrl in controllers.FindAll((p) => p.ResourceName == recourceName))
            {
                result += ctrl.Count;
            }
            return result;
        }

        public double ConsumedResourceOverTime(string recourceName, DateTime start, DateTime finish)
        {
            throw new NotImplementedException();
        }

        public bool AddNewController(Resource res)
        {
            controllers.Add(new Controller(res));
            return true;
        }

        public bool DeleteController(int id)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string result = $"Name: {Name}; Type: {Type}\n";
            foreach(Controller ctrl in controllers)
            {
                result += ctrl.ToString() + "\n";
            }
            return result;
        }
    }

    public interface IConsumer
    {
        string Name { get; set; }
        string Type { get; }
        List<Controller> Controllers { get; }

        bool hasController(string resourceName);

        double ConsumedResource(string recourceName);
        double ConsumedResourceOverTime(string recourceName, DateTime start, DateTime finish);

        bool AddNewController(Resource res);
        bool DeleteController(int id);
    }
}
+

