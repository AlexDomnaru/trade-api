using DTO;

namespace GraphQL.Types
{
    public class PortfolioType : ObjectType<Portfolio>
    {
        protected override void Configure(IObjectTypeDescriptor<Portfolio> descriptor)
        {
            descriptor.Field(u => u.PurchasePrice).Type<FloatType>();
            descriptor.Field(u => u.MarketPrice).Type<FloatType>();
        }
    }
}
