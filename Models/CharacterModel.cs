using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRPG.Models
{
    internal class CharacterModel
    {
        public class Character
        {
            public string? Name { get; set; }
            public Dictionary<string, string>? Attributes { get; set; }
            public Dictionary<string, Dictionary<string, string>>? Skills { get; set; }
            public List<Equipment>? Equipment { get; set; }
            public int Credits { get; set; }
            public string? HealthStatus { get; set; }
            public int ForcePoints { get; set; }
            public List<string>? Vehicles { get; set; }
        }

        public class Equipment
        {
            public string? Name { get; set; }
            public string? Type { get; set; }
            public string? Damage { get; set; }
        }

        public class RootObject
        {
            [JsonProperty("characters")]
            public List<Character> Characters { get; set; } = new List<Character>(); // Initialize with an empty list
        }
    }
}
