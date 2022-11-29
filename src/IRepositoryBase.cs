namespace ArchSample.Repository.Common;

public interface IRepositoryBase<TEntity> where TEntity : Entity
{
    Task<TEntity> FirstAsync(Func<TEntity, bool> predicate, CancellationToken ct = default);
    TEntity First(Func<TEntity, bool> predicate);
    Task<IEnumerable<TEntity>> ListAsync(Func<TEntity, bool> predicate, CancellationToken ct = default);
    IEnumerable<TEntity> List(Func<TEntity, bool> predicate);
    Task InsertAsync(TEntity entity, CancellationToken ct = default);
    Task InsertAsync(IEnumerable<TEntity> entities, CancellationToken ct = default);
    void Insert(TEntity entity);
    void Insert(IEnumerable<TEntity> entities);
    Task UpdateAsync(TEntity entity, CancellationToken ct = default);
    Task UpdateAsync(IEnumerable<TEntity> entity, CancellationToken ct = default);
    void Update(TEntity entity);
    void Update(IEnumerable<TEntity> entity);
    Task ArchiveAsync(Func<TEntity, bool> predicate, CancellationToken ct = default);
    void Archive(Func<TEntity, bool> predicate);
}