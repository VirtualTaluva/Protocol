using VirtualTaluva.Protocol.DataTypes.Attributes;
using VirtualTaluva.Protocol.Enums;

namespace VirtualTaluva.Protocol.Lobby.QuickMode
{
    /// <summary>
    /// In Quick mode, you must **identify** yourself. This action puts a unique name to your Tcp Connection for the server. This name will be used as your playername on every table that you will play.
    /// </summary>
    public class IdentifyCommand : AbstractLobbyCommand, ICommandWithResponse<IdentifyResponse>
    {
        /// <summary>
        /// The name you want to have on the server !
        /// </summary>
        [ExampleValue("SpongeBob")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IdentifyResponse Response(bool success, TaluvaMessageId msgId, string message)
        {
            return new IdentifyResponse(this) { Success = success, MessageId = msgId, Message = message };
        }
    }
}
