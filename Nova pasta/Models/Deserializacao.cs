using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Nova_pasta.Models {
    public class Deserializacao {
        public int Id { get; set; }
        // [JsonProperty("Nome_Product")]
        public string Product { get; set; }
        public decimal Price { get; set; }
        public DateTime SaleDate { get; set; }
    }
}