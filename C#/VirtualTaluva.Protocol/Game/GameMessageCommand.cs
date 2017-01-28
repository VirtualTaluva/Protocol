using VirtualTaluva.Protocol.DataTypes.Attributes;
using VirtualTaluva.Protocol.DataTypes.Enums;
using VirtualTaluva.Protocol.DataTypes.Json;
using VirtualTaluva.Protocol.DataTypes.Options;
using Newtonsoft.Json;

namespace VirtualTaluva.Protocol.Game
{
    /// <summary>
    /// This command is there to inform players of something. This is for additionnal information, ignoring this message should not change anything to the game.
    /// More information on ...
    ///  * [GameMessageOption]({VirtualTaluva.Protocol.DataTypes.Options.GameMessageOption})
    /// </summary>
    public class GameMessageCommand : AbstractGameCommand
    {
        /// <summary>
        /// The text message
        /// </summary>
        public string Message => Info.BuildMessage();

        /// <summary>
        /// The specific information of the message
        /// </summary>
        [ExampleValue(typeof(GameMessageOptionPlayerJoined))]
        [JsonConverter(typeof(OptionJsonConverter<GameMessageOption, GameMessageEnum>))]
        [JsonProperty(Order = 100)]
        public GameMessageOption Info { get; set; }
    }
}
