using VirtualTaluva.Protocol.Enums;

namespace VirtualTaluva.Protocol.Game
{
    /// <summary>
    /// The client is telling the server that he wants to sit out
    /// </summary>
    public class PlayerSitOutCommand : AbstractGameCommand, ICommandWithResponse<PlayerSitOutResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public PlayerSitOutResponse Response(bool success, TaluvaMessageId msgId, string message)
        {
            return new PlayerSitOutResponse(this) { Success = success, MessageId = msgId, Message = message };
        }
    }
}
