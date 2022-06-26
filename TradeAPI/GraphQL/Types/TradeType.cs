using GraphQL.Resolvers;
using TradeAPI.DataAccess.Models;

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
            descriptor.Field(u => u.SecurityId).Type<IntType>();
            descriptor.Field(u => u.BuyerId).Type<IntType>();

            descriptor.Field<TradeResolver>(t => t.GetTrades(default));
            descriptor.Field<TradeResolver>(t => t.GetTrade(default, default));
        }
    }
}
