using VirtualTaluva.Protocol.DataTypes.Attributes;

namespace VirtualTaluva.Protocol.Game
{
    /// <summary>
    /// The client is telling the server that he discards some cards.
    /// </summary>
    public class PlayerDiscardActionCommand : AbstractGameCommand
    {
        /// <summary>
        /// Cards discarded
        /// </summary>
        [ExampleValues(3,"2s","7c", "Kh")]
        public string[] CardsDiscarded { get; set; }
    }
}
