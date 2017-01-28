﻿using VirtualTaluva.Protocol.DataTypes.Attributes;
using VirtualTaluva.Protocol.DataTypes.Enums;

namespace VirtualTaluva.Protocol.Game
{
    /// <summary>
    /// This command is sent after the showdown to inform clients that some money has been won by some player
    /// </summary>
    public class PlayerWonPotCommand : AbstractGameCommand
    {
        /// <summary>
        /// The position on the table where is sitting the player that won something
        /// </summary>
        [ExampleValue(7)]
        public int NoSeat { get; set; }

        /// <summary>
        /// The Id of the pot that was won by the player
        /// </summary>
        [ExampleValue(0)]
        public int PotId { get; set; }

        /// <summary>
        /// The amount of money that was won by the player (Could be a fraction of the pot if there was a split.
        /// </summary>
        [ExampleValue(420)]
        public int WonAmount { get; set; }

        /// <summary>
        /// The amount of money that was in the pot. Bigger than "WonAmount" if the pot was splitted.
        /// </summary>
        [ExampleValue(1000)]
        public int TotalPotAmount { get; set; }

        /// <summary>
        /// The total amount of money in the pockets of the player after winning this money
        /// </summary>
        [ExampleValue(4200)]
        public int TotalPlayerMoney { get; set; }

        /// <summary>
        /// The cards that are responsible for winning the pot
        /// </summary>
        [ExampleValues(5, "5s", "5c", "5d", "Ad", "Ks")]
        public string[] WinningCards { get; set; }

        /// <summary>
        /// The hand that is responsible for winning the pot
        /// </summary>
        [ExampleValue(PokerHandEnum.ThreeOfAKind)]
        public PokerHandEnum WinningHand { get; set; }
    }
}
