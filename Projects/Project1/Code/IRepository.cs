namespace Project1.Code
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);
        IEnumerable<TEntity> Index();
        TEntity Update(TEntity entity);
        TEntity Delete (TEntity entity);
        IEnumerable<TEntity> Find(Func<TEntity,bool> predicate);
        bool IsExist(Func<TEntity, bool> predicate);

    }
}
