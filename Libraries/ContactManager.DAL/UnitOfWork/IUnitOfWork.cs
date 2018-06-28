using ContactManger.DAL.Repository;
using System;
namespace ContactManger.DAL.UnitOfWork
    
{
    public interface IUnitOfWork : IDisposable
    {
        #region Properties

        IGenericRepository<Contact> ContactRepository { get; }
        
        #endregion

        #region Public methods
        
        /// <summary>
        /// Save all the changes of the context to the database.
        /// </summary>
        void Commit();

        #endregion
    }
}
