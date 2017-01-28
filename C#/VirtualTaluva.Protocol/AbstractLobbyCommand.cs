using VirtualTaluva.Protocol.Enums;

namespace VirtualTaluva.Protocol
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstractLobbyCommand : AbstractCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public override TaluvaCommandEnum CommandType => TaluvaCommandEnum.Lobby;
    }
}
