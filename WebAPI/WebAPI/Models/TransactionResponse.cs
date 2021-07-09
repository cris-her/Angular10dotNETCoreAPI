using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class TransactionResponse
    {
        //[JsonProperty("token")]
        public string Token { get; private set; }
        //[JsonProperty("url")]
        public string Url { get; private set; }

        //NOT USED
    }
}
