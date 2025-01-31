﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Bybit.Net.Objects.Internal.Socket
{
    internal class BybitFuturesRequestMessage
    {
        [JsonProperty("op")]
        public string Operation { get; set; } = string.Empty;
        [JsonProperty("args")]
        public object[] Parameters { get; set; } = Array.Empty<object>();
    }

    internal class BybitSpotRequestMessage
    {
        [JsonProperty("topic")]
        public string Operation { get; set; } = string.Empty;
        [JsonProperty("params")]
        public Dictionary<string, object> Parameters { get; set; } = new Dictionary<string, object>();
        [JsonProperty("event")]
        public string Event { get; set; } = string.Empty;
    }
}
