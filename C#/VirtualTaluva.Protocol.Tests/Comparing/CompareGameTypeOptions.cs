﻿using VirtualTaluva.Protocol.DataTypes.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VirtualTaluva.Protocol.Tests.Comparing
{
    public static class CompareGameTypeOptions
    {
        public static void Compare(GameTypeOptions l, GameTypeOptions dl)
        {
            Assert.AreEqual(l.GetType(), dl.GetType());
        }
    }
}
