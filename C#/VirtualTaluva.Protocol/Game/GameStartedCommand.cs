﻿using System.Collections.Generic;
using VirtualTaluva.Protocol.DataTypes;
using VirtualTaluva.Protocol.DataTypes.Attributes;

namespace VirtualTaluva.Protocol.Game
{
    /// <summary>
    /// This command is sent at the start of every game.
    /// It's important to understand that a *game* is only one iteration. It's starts with blinds, then preflop, then ends when the pot is won. The next iteration will be a new *game*.
    /// </summary>
    public class GameStartedCommand : AbstractGameCommand
    {
        /// <summary>
        /// The amount needed for this player as blinds. If the player doesn't need to put any blinds, he will receive 0
        /// </summary>
        [ExampleValue(10)]
        public int NeededBlindAmount { get; set; }

        /// <summary>
        /// The information about every seats around the table
        /// </summary>
        [ExampleValues(1)]
        public List<SeatInfo> Seats { get; set; }
    }
}
