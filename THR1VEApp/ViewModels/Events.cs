using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace THR1VEApp.ViewModels
{
    public class Events
    {
        [JsonProperty("EventName")]
        public string Name { get; set; }

        [JsonProperty("Location")]
        public string Location { get; set; }

        [JsonProperty("Details")]
        public string Details { get; set; }

        [JsonProperty("Time")]
        public string Time { get; set; }
    }
}
