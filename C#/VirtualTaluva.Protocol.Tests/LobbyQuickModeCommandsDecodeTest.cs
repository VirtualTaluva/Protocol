using VirtualTaluva.Protocol.Lobby.QuickMode;
using VirtualTaluva.Protocol.Tests.Helpers;
using VirtualTaluva.Protocol.Tests.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VirtualTaluva.Protocol.Tests
{
    [TestClass]
    public class LobbyQuickModeCommandsDecodeTest
    {

        [TestMethod]
        public void IdentifyCommand()
        {
            var c = LobbyCommandMock.IdentifyCommand();
            var dc = EncodeDecodeHelper.GetDecodedCommand(c);
            CompareIdentifyCommand(c, dc);
        }

        [TestMethod]
        public void IdentifyResponse()
        {
            var c = LobbyCommandMock.IdentifyResponse();
            var dc = EncodeDecodeHelper.GetDecodedCommand(c);
            Assert.AreEqual(c.Success, dc.Success);
            CompareIdentifyCommand(c.Command, dc.Command);
        }

        private static void CompareIdentifyCommand(IdentifyCommand c, IdentifyCommand dc)
        {
            Assert.AreEqual(c.Name, dc.Name);
        }
    }
}
