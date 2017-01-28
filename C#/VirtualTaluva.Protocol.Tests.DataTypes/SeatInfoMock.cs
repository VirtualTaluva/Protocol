using System.Collections.Generic;
using VirtualTaluva.Protocol.DataTypes;
using VirtualTaluva.Protocol.DataTypes.Enums;

namespace VirtualTaluva.Protocol.Tests.DataTypes
{
    public static class SeatInfoMock
    {
        public static List<SeatInfo> AllSeats()
        {
            return new List<SeatInfo>()
            {
                SeatSix(),
                SeatSeven()
            };
        }
        public static SeatInfo SeatSix()
        {
            return new SeatInfo()
            {
                NoSeat = 6,
                Player = PlayerInfoMock.Diego(),
                SeatAttributes = new[] { SeatAttributeEnum.Dealer  }
            };
        }
        public static SeatInfo SeatSeven()
        {
            return new SeatInfo()
            {
                NoSeat = 7,
                Player = PlayerInfoMock.Dora(),
                SeatAttributes = new[] { SeatAttributeEnum.CurrentPlayer, SeatAttributeEnum.BigBlind }
            };
        }
    }
}
