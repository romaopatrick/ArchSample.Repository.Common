// ToDo: Implement this class once the database was chosen
// I've let this open to implementation because sometimes the database driver is not Entity Framework like

namespace ArchSample.Repository.Common;

public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
{
    public async Task<TEntity> FirstAsync(Func<TEntity, bool> predicate, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public TEntity First(Func<TEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public virtual Task<IEnumerable<TEntity>> ListAsync(Func<TEntity, bool> predicate, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
    public virtual IEnumerable<TEntity> List(Func<TEntity, bool> predicate)
    {
        throw new NotImplementedException();
    }
    
    public virtual Task InsertAsync(TEntity entity, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
    public virtual Task InsertAsync(IEnumerable<TEntity> entities, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
    public virtual void Insert(TEntity entity)
    {
        throw new NotImplementedException();
    }
    public virtual void Insert(IEnumerable<TEntity> entities)
    {
        throw new NotImplementedException();
    }

    public virtual Task UpdateAsync(TEntity entity, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
    public virtual Task UpdateAsync(IEnumerable<TEntity> entity, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
    public virtual void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
    public virtual void Update(IEnumerable<TEntity> entity)
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