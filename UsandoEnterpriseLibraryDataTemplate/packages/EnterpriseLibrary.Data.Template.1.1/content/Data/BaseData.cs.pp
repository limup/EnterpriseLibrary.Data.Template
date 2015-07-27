using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $rootnamespace$.Data
{
    public class BaseData : IDisposable
    {
        protected Database database;
        protected DbCommand command;
        protected IDataReader dataReader;

        /// <summary>
        /// <para>
        /// Construtor que cria a conexão
        /// </para>
        /// </summary>
        public BaseData()
        {
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory(), false);
            this.database = DatabaseFactory.CreateDatabase("default");
        }

        /// <summary>
        /// <para>
        /// Fecha a conexão com o banco.
        /// </para>
        /// </summary>
        public void Dispose()
        {
            database = null;

            if (command != null)
            {
                command.Dispose();
                command = null;
            }

            if (dataReader != null)
            {
                dataReader.Dispose();
                dataReader = null;
            }
        }
    }
}
