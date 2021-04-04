using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCounter.Models
{
    [DataContract]
    public class StatsModel
    {
        [DataMember]
        public long balance { get; set; }
        
        [DataMember]
        public long blocksFound { get; set; }
        
        [DataMember]
        public long immature { get; set; }
        
        [DataMember]
        public long lastShare { get; set; }

        [DataMember]
        public long paid { get; set; }

        [DataMember]
        public bool pending { get; set; } = false;
    }
}
