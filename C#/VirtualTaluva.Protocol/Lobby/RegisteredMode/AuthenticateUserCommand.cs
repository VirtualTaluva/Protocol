using VirtualTaluva.Protocol.DataTypes.Attributes;
using VirtualTaluva.Protocol.Enums;

namespace VirtualTaluva.Protocol.Lobby.RegisteredMode
{
    /// <summary>
    /// This command will try to authenticate the client against the user database on the server.
    /// </summary>
    public class AuthenticateUserCommand : AbstractLobbyCommand, ICommandWithResponse<AuthenticateUserResponse>
    {
        /// <summary>
        /// The username
        /// </summary>
        [ExampleValue("ericmas001")]
        public string Username { get; set; }
        /// <summary>
        /// The password associated with the username
        /// </summary>
        [ExampleValue("0nc3Up0nAT1m3")]
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public AuthenticateUserResponse Response(bool success, TaluvaMessageId msgId, string message)
        {
            return new AuthenticateUserResponse(this) { Success = success, MessageId = msgId, Message = message };
        }
    }
}
