using VirtualTaluva.Protocol.Enums;

namespace VirtualTaluva.Protocol
{
    /// <summary>
    /// This command is sent to inform the other end of the Tcp Connection that the communication should end
    /// </summary>
    public class DisconnectCommand : AbstractCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public override TaluvaCommandEnum CommandType => TaluvaCommandEnum.General;
    }
}
