using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class SetAccountTtl : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "setAccountTtl";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("ttl")]
            public AccountTtl Ttl { get; set; }
        }
    }
}