using GraphQL.Resolvers;
using TradeAPI.DataAccess.Models;

namespace GraphQL.Types
{
    public class SecurityType : ObjectType<Security>
    {
        protected override void Configure(IObjectTypeDescriptor<Security> descriptor)
        {
            descriptor.Field(u => u.Id).Type<IdType>();
            descriptor.Field(u => u.SecurityCode).Type<StringType>();
            descriptor.Field(u => u.MarketPrice).Type<FloatType>();

            descriptor.Field<SecurityResolver>(t => t.GetSecurities(default));
            descriptor.Field<SecurityResolver>(t => t.GetSecurity(default, default));
        }
    }
}
