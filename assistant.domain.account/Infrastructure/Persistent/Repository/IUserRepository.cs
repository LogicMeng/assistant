using assistant.domain.account.Infrastructure.Persistent.Entity;

namespace assistant.domain.account.Infrastructure.Persistent.Repository
{
    public interface IUserRepository : IBaseRepository<UserEntity>
    {
        void Save(UserEntity user);
    }
}
