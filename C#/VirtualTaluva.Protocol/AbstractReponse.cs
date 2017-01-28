﻿using VirtualTaluva.Protocol.DataTypes.Attributes;
using VirtualTaluva.Protocol.Enums;
using Newtonsoft.Json;

namespace VirtualTaluva.Protocol
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractBluffinReponse<T> : AbstractCommand, IResponse
        where T : AbstractCommand
    {
        /// <summary>
        /// True if the command was a success
        /// </summary>
        [ExampleValue(true)]
        [JsonProperty(Order = -21)]
        public bool Success { get; set; }
        /// <summary>
        /// The Id of the message. None if no message
        /// </summary>
        [ExampleValue(TaluvaMessageId.None)]
        [JsonProperty(Order = -20)]
        public TaluvaMessageId MessageId { get; set; }
        /// <summary>
        /// The message. Empty if no messages
        /// </summary>
        [ExampleValue("")]
        [JsonProperty(Order = -19)]
        public string Message { get; set; }

        /// <summary>
        /// The command who initiated this response
        /// </summary>
        [JsonProperty(Order = 9999)]
        public T Command { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public override TaluvaCommandEnum CommandType => Command.CommandType;

        /// <summary>
        /// 
        /// </summary>
        protected AbstractBluffinReponse()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        protected AbstractBluffinReponse(T command)
        {
            Command = command;
        }
    }
}
