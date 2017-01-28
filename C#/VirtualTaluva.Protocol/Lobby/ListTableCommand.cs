using VirtualTaluva.Protocol.DataTypes.Attributes;
using VirtualTaluva.Protocol.DataTypes.Enums;
using VirtualTaluva.Protocol.Enums;

namespace VirtualTaluva.Protocol.Lobby
{
    /// <summary>
    /// To list tables, you have to send a **List Table** command with the types of lobbys you are interested in.
    /// The list of active tables will be sent back
    /// </summary>
    public class ListTableCommand : AbstractLobbyCommand, ICommandWithResponse<ListTableResponse>
    {
        /// <summary>
        /// All the different types of lobby we want to see tables of.
        /// </summary>
        [ExampleValues(2, LobbyTypeEnum.QuickMode, LobbyTypeEnum.RegisteredMode)]
        public LobbyTypeEnum[] LobbyTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ListTableResponse Response(bool success, TaluvaMessageId msgId, string message)
        {
            return new ListTableResponse(this) { Success = success, MessageId = msgId, Message = message };
        }
    }
}
