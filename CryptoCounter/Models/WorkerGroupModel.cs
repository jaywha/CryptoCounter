using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCounter.Models
{
    [DataContract]
    public class WorkerGroupModel
    {
        [DataMember]
        public string lastBeat { get; set; }

        [DataMember]
        public float hr { get; set; }

        [DataMember]
        public bool offline { get; set; } = false;
        
        [DataMember]
        public float hr2 { get; set; }
    }
}
