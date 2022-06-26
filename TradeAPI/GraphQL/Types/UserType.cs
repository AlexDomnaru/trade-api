using GraphQL.Resolvers;
using TradeAPI.DataAccess.Models;

namespace GraphQL.Types
{
    public class UserType: ObjectType<User>
    {
        protected override void Configure(IObjectTypeDescriptor<User> descriptor)
        {
            descriptor.Field(u => u.Id).Type<IdType>();
            descriptor.Field(u => u.Name).Type<StringType>();

            descriptor.Field<UserResolver>(t => t.GetUsers(default));
            descriptor.Field<UserResolver>(t => t.GetUser(default, default));
        }
    }
}
