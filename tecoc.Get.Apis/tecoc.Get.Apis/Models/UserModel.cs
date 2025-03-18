using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tecoc.Get.Apis.Models
{
    public class UserModel
    {
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("name")]
        public NameModel Name { get; set; }  

        [JsonPropertyName("email")]      
        public string Email { get; set; }  

        [JsonPropertyName("phone")]  
        public string Phone { get; set; }

        [JsonPropertyName("cell")]  
        public string Cell { get; set; }

        // [JsonPropertyName("id")]  
        // public IdModel Id { get; set; }

        [JsonPropertyName("picture")]  
        public PictureModel Picture { get; set; }

        [JsonPropertyName("nat")]  
        public string Nat { get; set; }
    }
}