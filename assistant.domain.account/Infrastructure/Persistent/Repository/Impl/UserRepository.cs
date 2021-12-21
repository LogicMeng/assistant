using assistant.domain.account.Infrastructure.Persistent.Entity;
using assistant.infrastructure.data.context;

namespace assistant.domain.account.Infrastructure.Persistent.Repository.Impl
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(AssistantContext context) : base(context) { }
    }
}
