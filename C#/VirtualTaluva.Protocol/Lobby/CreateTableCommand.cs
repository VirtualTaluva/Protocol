using VirtualTaluva.Protocol.DataTypes;
using VirtualTaluva.Protocol.Enums;

namespace VirtualTaluva.Protocol.Lobby
{
    /// <summary>
    /// To create a new table, you have to send a **Create Table** command with all the parameters of the poker table.
    /// If successful, the id of the table will be received. If not, server will send "-1".
    /// More information on ...
    ///  * [LobbyOptions]({VirtualTaluva.Protocol.DataTypes.Options.LobbyOptions})
    ///  * [GameTypeOptions]({VirtualTaluva.Protocol.DataTypes.Options.GameTypeOptions})
    /// </summary>
    public class CreateTableCommand : AbstractLobbyCommand, ICommandWithResponse<CreateTableResponse>
    {
        /// <summary>
        /// Parameters of the poker table
        /// </summary>
        public TableParams Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public CreateTableResponse Response(bool success, TaluvaMessageId msgId, string message)
        {
            return new CreateTableResponse(this) { Success = success, MessageId = msgId, Message = message };
        }
    }
}
