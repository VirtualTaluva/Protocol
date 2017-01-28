using System.Linq;
using VirtualTaluva.Protocol.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VirtualTaluva.Protocol.Tests.Comparing
{
    public static class CompareSeatInfo
    {
        public static void Compare(SeatInfo s, SeatInfo ds)
        {
            Assert.IsFalse(s.SeatAttributes.Except(ds.SeatAttributes).Any());
            Assert.AreEqual(s.SeatAttributes.Length, ds.SeatAttributes.Length);
            Assert.AreEqual(s.NoSeat, ds.NoSeat);
            ComparePlayerInfo.Compare(s.Player, ds.Player);
        }
    }
}
