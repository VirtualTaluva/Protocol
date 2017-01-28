﻿using System.Collections.Generic;
using VirtualTaluva.Protocol.DataTypes.Attributes;

namespace VirtualTaluva.Protocol.Game
{
    /// <summary>
    /// This command is issued by the server when a betting round is ending. For example, everybody called on the flop. It's the end of the flop. Every client receive this command.
    /// </summary>
    public class BetTurnEndedCommand : AbstractGameCommand
    {
        /// <summary>
        /// All the pots on the table. Usually only one, but can have more if some players are all-in.
        /// </summary>
        [ExampleValues(2, 4200, 420)]
        public List<int> PotsAmounts { get; set; }
    }
}
