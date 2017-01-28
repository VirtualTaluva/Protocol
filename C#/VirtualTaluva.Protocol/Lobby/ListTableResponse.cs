﻿using System.Collections.Generic;
using VirtualTaluva.Protocol.DataTypes;
using VirtualTaluva.Protocol.DataTypes.Attributes;

namespace VirtualTaluva.Protocol.Lobby
{
    /// <summary>
    /// 
    /// </summary>
    public class ListTableResponse : AbstractBluffinReponse<ListTableCommand>
    {
        /// <summary>
        /// All the active tables on the server
        /// </summary>
        [ExampleValues(1)]
        public List<TupleTable> Tables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public ListTableResponse(ListTableCommand command)
            : base(command)
        {
        }
    }
}
