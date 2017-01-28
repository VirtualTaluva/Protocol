using VirtualTaluva.Protocol.DataTypes.Attributes;

namespace VirtualTaluva.Protocol.Lobby
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateTableResponse : AbstractBluffinReponse<CreateTableCommand>
    {
        /// <summary>
        /// The id of the table that was created
        /// </summary>
        [ExampleValue(42)]
        public int IdTable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public CreateTableResponse(CreateTableCommand command)
            : base(command)
        {
        }
    }
}
