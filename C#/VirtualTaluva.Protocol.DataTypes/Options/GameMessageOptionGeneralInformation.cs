﻿using VirtualTaluva.Protocol.DataTypes.Attributes;
using VirtualTaluva.Protocol.DataTypes.Enums;

namespace VirtualTaluva.Protocol.DataTypes.Options
{
    /// <summary>
    ///  
    /// </summary>
    public class GameMessageOptionGeneralInformation : GameMessageOption
    {
        /// <summary>
        /// 
        /// </summary>
        public override GameMessageEnum OptionType => GameMessageEnum.GeneralInformation;

        /// <summary>
        /// Message
        /// </summary>
        [ExampleValue("General message sent by the server")]
        public string Message { get; set; }

        /// <summary>
        /// Function to build the message
        /// </summary>
        public override string BuildMessage() => Message;
    }
}
