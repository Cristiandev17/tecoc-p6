using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tecoc.Get.Apis.Models
{
    public class Response
    {
        [JsonPropertyName("results")]
        public List<UserModel> Results { get; set; }        
    }
}