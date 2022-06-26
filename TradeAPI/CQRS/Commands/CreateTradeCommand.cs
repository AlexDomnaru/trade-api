using MediatR;

namespace CQRS.Commands
{
    public class CreateTradeCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int SecurityId { get; set; }
        public int UserId { get; set; }

        public CreateTradeCommand(int quantity, int securityId, int buyerId)
        {
            Quantity = quantity;
            SecurityId = securityId;
            UserId = buyerId;
        }
    }
}
