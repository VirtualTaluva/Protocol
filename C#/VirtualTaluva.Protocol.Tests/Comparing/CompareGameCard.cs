using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VirtualTaluva.Protocol.Tests.Comparing
{
    public static class CompareGameCard
    {
        public static void Compare(string c, string dc)
        {
            Assert.AreEqual(c.ToLower(), dc.ToLower());
        }
    }
}
