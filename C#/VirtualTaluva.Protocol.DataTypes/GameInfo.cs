using System.Collections.Generic;
using VirtualTaluva.Protocol.DataTypes.Attributes;
using VirtualTaluva.Protocol.DataTypes.Enums;

namespace VirtualTaluva.Protocol.DataTypes
{
    /// <summary>
    /// Information of a Taluva Game Type
    /// </summary>
    public class GameInfo
    {
        /// <summary>
        /// Type of Game
        /// </summary>
        [ExampleValue(GameTypeEnum.Standard)]
        public GameTypeEnum GameType { get; set; }

        /// <summary>
        /// Available variants of this type of game
        /// </summary>
        [ExampleValues(1, GameSubTypeEnum.Standard)]
        public GameSubTypeEnum[] AvailableVariants { get; set; }

        ///// <summary>
        ///// Available betting limits for this type of game
        ///// </summary>
        //[ExampleValues(3, LimitTypeEnum.NoLimit, LimitTypeEnum.FixedLimit, LimitTypeEnum.PotLimit)]
        //public LimitTypeEnum[] AvailableLimits { get; set; }

        ///// <summary>
        ///// Available blind types for this type of game
        ///// </summary>
        //[ExampleValues(1, BlindTypeEnum.Blinds)]
        //public BlindTypeEnum[] AvailableBlinds { get; set; }

        /// <summary>
        /// Minimum number of player on the table to be able to play the game
        /// </summary>
        [ExampleValue(2)]
        public int MinPlayers { get; set; }

        /// <summary>
        /// Maximum number of player on the table
        /// </summary>
        [ExampleValue(4)]
        public int MaxPlayers { get; set; }
    }
}
