﻿using System.Collections.Generic;
using VirtualTaluva.Protocol.DataTypes;
using VirtualTaluva.Protocol.DataTypes.Enums;

namespace VirtualTaluva.Protocol.Tests.DataTypes
{
    public static class TupleTableMock
    {
        public static IEnumerable<TupleTable> AllTables()
        {
            return new[]
            {
                TableOne(),
                TableTwo(),
                TableThree()
            };
        }
        public static TupleTable TableOne()
        {
            return new TupleTable()
            {
                IdTable = 42,
                NbPlayers = 3,
                PossibleAction = LobbyActionEnum.Join,
                Params = TableParamsMock.ParamsOne()
            };
        }
        public static TupleTable TableTwo()
        {
            return new TupleTable()
                {
                    IdTable = 420,
                    NbPlayers = 7,
                    PossibleAction = LobbyActionEnum.Leave,
                    Params = TableParamsMock.ParamsTwo()
                };
        }
        public static TupleTable TableThree()
        {
            return new TupleTable()
            {
                IdTable = 4200,
                NbPlayers = 6,
                PossibleAction = LobbyActionEnum.None,
                Params = TableParamsMock.ParamsThree()
            };
        }
    }
}
