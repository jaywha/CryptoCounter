using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCounter.Models
{
    [DataContract]
    public class AccountReturnModel
    {
        [DataMember]
        public float currentHashrate { get; set; }

        [DataMember]
        public string currentLuck { get; set; }

        [DataMember]
        public float hashrate { get; set; }

        [DataMember]
        public long pageSize { get; set; }

        [DataMember]
        public JsonArray payments { get; set; }

        [DataMember]
        public long paymentsTotal { get; set; }

        [DataMember]
        public JsonArray rewards { get; set; }

        [DataMember]
        public long roundShares { get; set; }

        [DataMember]
        public JsonArray shares { get; set; }

        [DataMember]
        public StatsModel stats { get; set; }

        [DataMember]
        public JsonArray sumrewards { get; set; }

        [DataMember]
        public WorkerModel workers { get; set; }

        [DataMember]
        public long workersOffline { get; set; }

        [DataMember]
        public long workersOnline { get; set; }

        [DataMember]
        public long workersTotal { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "24hreward")]
        public long twentyfourhreward { get; set; }
        
        [DataMember]
        [JsonProperty(PropertyName = "24hnumreward")]
        public long twentyfourhnumreward { get; set; }
    }
}
