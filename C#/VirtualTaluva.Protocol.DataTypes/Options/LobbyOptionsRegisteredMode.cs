﻿using VirtualTaluva.Protocol.DataTypes.Attributes;
using VirtualTaluva.Protocol.DataTypes.Enums;
using Newtonsoft.Json;

namespace VirtualTaluva.Protocol.DataTypes.Options
{
    /// <summary>
    /// The Registered mode is a mode where a player connects with an account. He then have some money, that he uses throughout different games. When entering a game, he will take some of that money to play, and when he leaves what was left of that money will be given back to him.
    /// </summary>
    public class LobbyOptionsRegisteredMode : LobbyOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public override LobbyTypeEnum OptionType => LobbyTypeEnum.RegisteredMode;

        ///// <summary>
        ///// MinimumBuyInParameter
        ///// </summary>
        //[JsonIgnore]
        //public override BuyInParameterEnum MinimumBuyInParameter => BuyInParameterEnum.Multiplicator;

        ///// <summary>
        ///// MinimumBuyInValue
        ///// </summary>
        //[JsonIgnore]
        //public override int MinimumBuyInValue => 20;
        ///// <summary>
        ///// MaximumBuyInParameter
        ///// </summary>
        //[JsonIgnore]
        //public override BuyInParameterEnum MaximumBuyInParameter => IsMaximumBuyInLimited ? BuyInParameterEnum.Multiplicator : BuyInParameterEnum.Unlimited;

        ///// <summary>
        ///// MaximumBuyInValue
        ///// </summary>
        //[JsonIgnore]
        //public override int MaximumBuyInValue => 100;

        ///// <summary>
        ///// If Limited, the maximum buy-in will be 100*MoneyUnit. If not, a player can sit with all his money if he wants.
        ///// </summary>
        //[ExampleValue(true)]
        //public bool IsMaximumBuyInLimited { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public LobbyOptionsRegisteredMode()
        {
            //IsMaximumBuyInLimited = false;
        }
    }
}
