﻿using VirtualTaluva.Protocol.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VirtualTaluva.Protocol.Tests.Comparing
{
    public static class CompareDiscardInfo
    {
        public static void Compare(DiscardInfo d, DiscardInfo dd)
        {
            Assert.AreEqual(d.NbCardsDiscarded, dd.NbCardsDiscarded);
            Assert.AreEqual(d.NoSeat, dd.NoSeat);
        }
    }
}
