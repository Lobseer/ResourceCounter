using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Project2Resurses
{
    [DataContract]
    public class ResourceList
    {      
        [DataMember]
        private List<Resource> availableResources = new List<Resource>();
        
        public List<Resource> AvailableResources
        {
            get
            {
                return availableResources;
            }
        }

        //private HashSet<Resource> ares = new HashSet<Resource>();

        //private Dictionary<string, Resource> resources = new Dictionary<string, Resource>();

        public bool Add(Resource res)
        {
            //if (availableResources.Exists((p) => res.Name == p)) return false;
            //resources.Any((p) => p.Key == res.Name);
            if (AvailableResources.Any((p) => p.Name == res.Name)) return false;

            DataContractJsonSerializer jSer = new DataContractJsonSerializer(typeof(ResourceList));

            AvailableResources.Add(res);
            return true;
        }

        public Resource GetResource(string name)
        {
            return AvailableResources.FirstOrDefault((p) => p.Name == name);
        }

        public bool Remove(string name)
        {
            Resource toDel = GetResource(name);
            if(toDel!=null)
            {
                AvailableResources.Remove(toDel);
                return true;
            }
            return false;
        }

    }
}
