using VirtualTaluva.Protocol.DataTypes;
using VirtualTaluva.Protocol.DataTypes.Enums;

namespace VirtualTaluva.Protocol.Tests.DataTypes
{

    public static class PlayerInfoMock
    {
        public static PlayerInfo Dora()
        {
            return new PlayerInfo()
            {
                State = PlayerStateEnum.Playing,
                NoSeat = 7,
                Name = "Dora",
                FaceDownCards = new[] { GameCardMock.AceOfClubs(), GameCardMock.JackOfHearts() },
                FaceUpCards = new string[0],
                MoneyBetAmnt = 84,
                MoneySafeAmnt = 126
            };
        }

        public static PlayerInfo Diego()
        {
            return new PlayerInfo()
            {
                NoSeat = 6,
                Name = "Diego",
                FaceDownCards = new[] { GameCardMock.TenOfDiamonds(), GameCardMock.TwoOfSpades() },
                FaceUpCards = new[] { GameCardMock.AceOfClubs() },
                MoneyBetAmnt = 21,
                MoneySafeAmnt = 63
            };
        }
    }
}
