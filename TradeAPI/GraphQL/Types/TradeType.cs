using DTO;

namespace GraphQL.Types
{
    public class TradeType : ObjectType<Trade>
    {
        protected override void Configure(IObjectTypeDescriptor<Trade> descriptor)
        {
            descriptor.Field(u => u.Id).Type<IdType>();
            descriptor.Field(u => u.TradePrice).Type<FloatType>();
            descriptor.Field(u => u.Quantity).Type<IntType>();
            descriptor.Field(u => u.Date).Type<DateTimeType>();
        }
    }
}
