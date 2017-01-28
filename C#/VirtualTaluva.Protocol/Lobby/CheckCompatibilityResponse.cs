using System.Collections.Generic;
using VirtualTaluva.Protocol.DataTypes;
using VirtualTaluva.Protocol.DataTypes.Attributes;
using VirtualTaluva.Protocol.DataTypes.Enums;

namespace VirtualTaluva.Protocol.Lobby
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckCompatibilityResponse : AbstractBluffinReponse<CheckCompatibilityCommand>
    {
        /// <summary>
        /// The version of the Implemented Bluffin Protocol by the client, Represented as "Major.Minor.Revision"
        /// </summary>
        [ExampleValue("3.0.0")]
        public string ImplementedProtocolVersion { get; set; }

        /// <summary>
        /// The LobbyTypes available on the server
        /// </summary>
        [ExampleValues(2, LobbyTypeEnum.QuickMode, LobbyTypeEnum.RegisteredMode)]
        public LobbyTypeEnum[] SupportedLobbyTypes { get; set; }

        /// <summary>
        /// The different games available on the server
        /// </summary>
        [ExampleValues(1)]
        public GameInfo[] AvailableGames { get; set; }

        /// <summary>
        /// Something to identify what is the server.
        /// </summary>
        [ExampleValue("VirtualTaluva.Server .Net 1.0.0")]
        public string ServerIdentification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public CheckCompatibilityResponse(CheckCompatibilityCommand command)
            : base(command)
        {
        }
    }
}
