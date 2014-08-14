using System;


namespace FileExchange.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}