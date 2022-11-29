// ToDo: Implement this class once the database was chosen
// I've let this open to implementation because sometimes the database driver is not Entity Framework like

namespace ArchSample.Repository.Common;

public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
{
    public virtual Task<IEnumerable<TEntity>> ListAsync(Func<TEntity, bool> predicate, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
    public virtual IEnumerable<TEntity> List(Func<TEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }
    
    public virtual Task<TEntity> InsertAsync(TEntity entity, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
    public virtual Task<IEnumerable<TEntity>> InsertAsync(IEnumerable<TEntity> entities, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
    public virtual TEntity Insert(TEntity entity)
    {
        throw new NotImplementedException();
    }
    public virtual IEnumerable<TEntity> Insert(IEnumerable<TEntity> entities)
    {
        throw new NotImplementedException();
    }

    public virtual Task<TEntity> UpdateAsync(TEntity entity, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
    public virtual Task<IEnumerable<TEntity>> UpdateAsync(IEnumerable<TEntity> entity, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
    public virtual TEntity Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
    public virtual IEnumerable<TEntity> Update(IEnumerable<TEntity> entity)
    {
        throw new NotImplementedException();
    }

    public virtual Task ArchiveAsync(Func<TEntity, bool> predicate, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
    public virtual void Archive(Func<TEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }
}