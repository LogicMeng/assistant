using assistant.domain.account.Infrastructure.Persistent.Entity;
using assistant.infrastructure.data.context;
using System.Linq.Expressions;

namespace assistant.domain.account.Infrastructure.Persistent.Repository.Impl;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly AssistantContext _context;

    public BaseRepository(AssistantContext context)
    {
        _context = context;
    }

    public AssistantContext Context { get => _context; }

    #region Read

    /// <summary>
    /// 获取全部实体集合
    /// </summary>
    /// <returns></returns>
    public virtual List<TEntity> GetAllList()
    {
        return _context.Set<TEntity>().ToList();
    }

    /// <summary>
    /// 根据lambda表达式获取实体集合
    /// </summary>
    /// <param name="predicate">条件表达式</param>
    /// <returns></returns>
    public virtual List<TEntity> GetList(Expression<Func<TEntity, bool>> predicate)
    {
        return _context.Set<TEntity>().Where(predicate).ToList();
    }

    #endregion

    #region Save

    /// <summary>
    /// 保存实体
    /// </summary>
    /// <param name="entity">实体</param>
    public virtual void Save(TEntity entity)
    {
        _context.Add(entity);
    }

    #endregion
}
