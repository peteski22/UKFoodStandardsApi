namespace InfinityWorks.TechTest.Client.Model
{    
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class FsaEstablishmentList
    {
        [JsonPropertyName("establishments")]
        public List<FsaEstablishment> Establishments { get; set; }
    }
}
