using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails_H3.Controllers
{
    public interface IController<T, PKEY>
    {
        /// <summary>
        /// Used to create object in table
        /// </summary>
        /// <param name="object">Object reference</param>
        void Create(T @obj);
        /// <summary>
        /// Used to create object in table
        /// </summary>
        /// <param name="object">Object reference</param>
        void Update(T @obj);
        /// <summary>
        /// Used to delete specfic object in table
        /// </summary>
        /// <param name="key">Primary key of object</param>
        void Delete(PKEY @obj);
        /// <summary>
        /// Used to delete all objects in table
        /// </summary>
        void DeleteAll();
        /// <summary>
        /// Used to get all objects in table
        /// </summary>
        List<T> GetAll();
        /// <summary>
        /// Used to get specfic object
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Primary key of object</returns>
        T Get(PKEY key);
    }
}
