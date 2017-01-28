﻿using VirtualTaluva.Protocol.DataTypes.Attributes;
using VirtualTaluva.Protocol.Enums;
using Newtonsoft.Json;

namespace VirtualTaluva.Protocol
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstractGameCommand : AbstractCommand, IGameCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public override TaluvaCommandEnum CommandType => TaluvaCommandEnum.Game;

        /// <summary>
        /// The id of the table where this command needs to go
        /// </summary>
        [ExampleValue(42)]
        [JsonProperty(Order = -42)]
        public int TableId { get; set; }
    }
}
