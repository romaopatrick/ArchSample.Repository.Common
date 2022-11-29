namespace ArchSample.Repository.Common;

public interface IRepositoryBase<TEntity> where TEntity : Entity
{
    Task<TEntity> FirstAsync(Guid id);
    TEntity First(Guid id);
    Task<IEnumerable<TEntity>> ListAsync(Func<TEntity, bool> predicate, CancellationToken ct = default);
    IEnumerable<TEntity> List(Func<TEntity, bool> predicate);
    Task<TEntity> InsertAsync(TEntity entity, CancellationToken ct = default);
    Task<IEnumerable<TEntity>> InsertAsync(IEnumerable<TEntity> entities, CancellationToken ct = default);
    TEntity Insert(TEntity entity);
    IEnumerable<TEntity> Insert(IEnumerable<TEntity> entities);
    Task<TEntity> UpdateAsync(TEntity entity, CancellationToken ct = default);
    Task<IEnumerable<TEntity>> UpdateAsync(IEnumerable<TEntity> entity, CancellationToken ct = default);
    TEntity Update(TEntity entity);
    IEnumerable<TEntity> Update(IEnumerable<TEntity> entity);
    Task ArchiveAsync(Func<TEntity, bool> predicate, CancellationToken ct = default);
    void Archive(Func<TEntity, bool> predicate);
}