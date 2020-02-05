using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AutoShop_Shared.Services;
using System.ComponentModel.DataAnnotations;

namespace AutoShop_Shared.Models
{
    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("email")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="L'email est obligatoire")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Picture { get; set; }
        public byte Level { get; set; }
        public uint Experience { get; set; }

        [JsonProperty("badge")]
        public Badge ActiveBadge { get; set; }
        public List<Badge> Achievements { get; set; }
    }
}
