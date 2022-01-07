using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kokos_DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Поиск элемента
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Find(int id);

        /// <summary>
        /// Получить все сущности
        /// </summary>
        /// <param name="filter">Фильтр</param>
        /// <param name="orderBy">Сортировка</param>
        /// <param name="includeProperties">Включить в результат запроса данные из связанной таблицы</param>
        /// <param name="isTracking">Все запросы в EF Core по умолчанию отслеживаются. Иногда это может излишне нагружать систему 
        /// Если используется запрос только для поиска, а не для редактирования данных то можно установить флаг в значение false
        /// и система будет работать эффективнее</param>
        /// <returns></returns>
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null,
            bool isTracking = true  
            );

        /// <summary>
        /// Получить один элемент
        /// </summary>
        /// <param name="filter">Фильтр</param>
        /// <param name="includeProperties">Включить в результат запроса данные из связанной таблицы</param>
        /// <param name="isTracking">Все запросы в EF Core по умолчанию отслеживаются. Иногда это может излишне нагружать систему 
        /// Если используется запрос только для поиска, а не для редактирования данных то можно установить флаг в значение false
        /// и система будет работать эффективнее</param>
        /// <returns></returns>
        T FirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null,
            bool isTracking = true
            );

        /// <summary>
        /// Добавить экземпляр сущности в БД 
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// Удалить экземпляр сущности из БД 
        /// </summary>
        /// <param name="entity"></param>
        void Remove(T entity);

        /// <summary>
        /// Сохранить изменения в БД
        /// </summary>
        void Save();
    }
}
