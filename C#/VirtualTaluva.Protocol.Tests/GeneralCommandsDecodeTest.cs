using VirtualTaluva.Protocol.Tests.DataTypes;
using VirtualTaluva.Protocol.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VirtualTaluva.Protocol.Tests
{
    [TestClass]
    public class GeneralCommandsDecodeTest
    {

        [TestMethod]
        public void DisconnectCommand()
        {
            var c = GeneralCommandMock.DisconnectCommand();
            var dc =EncodeDecodeHelper.GetDecodedCommand(c);
            Assert.AreEqual(c.CommandName, dc.CommandName);
        }
    }
}
