using MediatR;

namespace CQRS.Commands
{
    public class DeleteTradeCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public DeleteTradeCommand(int id)
        {
            Id = id;
        }
    }
}
