using InfraXF.Models;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using SQLiteNetExtensions.Extensions;

namespace InfraXF.Services.Armazenamento
{
    public class DataAcess : IDisposable
    {
        private SQLiteConnection connection;
        public DataAcess()
        {
            var sqlite = DependencyService.Get<ISQLite>();
            connection = new SQLiteConnection(sqlite.Platform, System.IO.Path.Combine(sqlite.DirectoryDB, "InfraXF.db3"));
            connection.CreateTable<Produto>();
            connection.CreateTable<Usuario>();
        }

        public void Inserir<T>(T model)
        {
            connection.Insert(model);
        }

        public void Atualizar<T>(T model)
        {
            connection.Update(model);
        }

        public void Deletar<T>(T model)
        {
            connection.Delete(model);
        }

        public T First<T>(bool WithChildren) where T : class
        {
            if (WithChildren)
            {
                return connection.GetAllWithChildren<T>().FirstOrDefault();
            }
            else
            {
                return connection.Table<T>().FirstOrDefault();
            }
        }

         public  List<T> GeList<T>(bool WithChildren) where T : class
        {
            if (WithChildren)
            {
                return connection.GetAllWithChildren<T>().ToList();
            }
            else
            {
                return connection.Table<T>().ToList();
            }
        }


        public T Find<T>(int pk, bool WithChildren) where T : class
        {
            if (WithChildren)
            {
                return connection.GetAllWithChildren<T>().FirstOrDefault(m => m.GetHashCode() == pk);
            }
            else
            {
                return connection.Table<T>().FirstOrDefault(m => m.GetHashCode() == pk);
            }
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
