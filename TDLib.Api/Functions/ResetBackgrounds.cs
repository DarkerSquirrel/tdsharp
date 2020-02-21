using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Resets list of installed backgrounds to its default value
        /// </summary>
        public class ResetBackgrounds : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "resetBackgrounds";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
        }


        /// <summary>
        /// Resets list of installed backgrounds to its default value
        /// </summary>
        public static Task<Ok> ResetBackgroundsAsync(this Client client)
        {
            return client.ExecuteAsync(new ResetBackgrounds
            {
            });
        }
    }
}