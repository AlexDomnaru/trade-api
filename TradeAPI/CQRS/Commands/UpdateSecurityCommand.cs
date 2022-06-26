using MediatR;

namespace CQRS.Commands
{
    public class UpdateSecurityCommand : IRequest<bool>
    {
        public int SecurityId { get; set; }
        public float NewPrice { get; set; }

        public UpdateSecurityCommand(int id, float newPrice)
        {
            SecurityId = id;
            NewPrice = newPrice;
        }
    }
}
