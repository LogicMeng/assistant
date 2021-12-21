using assistant.domain.account.Infrastructure.Persistent.Entity;
using assistant.infrastructure.data.context;

namespace assistant.domain.account.Infrastructure.Persistent.Repository;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    AssistantContext Context { get; }

}
