using VirtualTaluva.Protocol.DataTypes;
using VirtualTaluva.Protocol.DataTypes.Enums;
using VirtualTaluva.Protocol.DataTypes.Options;

namespace VirtualTaluva.Protocol.Tests.DataTypes
{
    public static class TableParamsMock
    {
        public static TableParams ParamsOne()
        {
            return new TableParams()
            {
                Blind = BlindTypeEnum.Blinds,
                Options = new GameTypeOptionsStandard(),
                GameSize = 10,
                Limit = LimitTypeEnum.NoLimit,
                Lobby = new LobbyOptionsQuickMode
                {
                    StartingAmount = 1500
                },
                MaxPlayers = 5,
                MinPlayersToStart = 10,
                TableName = "Table One",
                Arguments = "",
                Variant = GameSubTypeEnum.Standard,
                WaitingTimes = new ConfigurableWaitingTimes
                {
                    AfterBoardDealed = 1,
                    AfterPlayerAction = 2,
                    AfterPotWon = 3
                }
            };
        }
        public static TableParams ParamsTwo()
        {
            return new TableParams()
            {
                Blind = BlindTypeEnum.Blinds,
                Options = new GameTypeOptionsStandard(),
                GameSize = 100,
                Limit = LimitTypeEnum.FixedLimit,
                Lobby = new LobbyOptionsRegisteredMode
                {
                    IsMaximumBuyInLimited = true
                },
                MaxPlayers = 10,
                MinPlayersToStart = 8,
                TableName = "Table Two",
                Arguments = "",
                Variant = GameSubTypeEnum.Standard,
                WaitingTimes = new ConfigurableWaitingTimes
                {
                    AfterBoardDealed = 1,
                    AfterPlayerAction = 2,
                    AfterPotWon = 3
                }
            };
        }
        public static TableParams ParamsThree()
        {
            return new TableParams()
            {
                Blind = BlindTypeEnum.Blinds,
                Options = new GameTypeOptionsStandard(),
                GameSize = 1000,
                Limit = LimitTypeEnum.NoLimit,
                Lobby = new LobbyOptionsRegisteredMode
                {
                    IsMaximumBuyInLimited = true
                },
                MaxPlayers = 6,
                MinPlayersToStart = 3,
                TableName = "Table Three",
                Arguments = "--verbose",
                Variant = GameSubTypeEnum.Standard,
                WaitingTimes = new ConfigurableWaitingTimes
                {
                    AfterBoardDealed = 1,
                    AfterPlayerAction = 2,
                    AfterPotWon = 3
                }
            };
        }
    }
}
