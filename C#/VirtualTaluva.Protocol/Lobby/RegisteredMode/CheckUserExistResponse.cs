using VirtualTaluva.Protocol.DataTypes.Attributes;

namespace VirtualTaluva.Protocol.Lobby.RegisteredMode
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckUserExistResponse : AbstractBluffinReponse<CheckUserExistCommand>
    {
        /// <summary>
        /// true if the username exists
        /// </summary>
        [ExampleValue(true)]
        public bool Exist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public CheckUserExistResponse(CheckUserExistCommand command)
            : base(command)
        {
        }
    }
}
