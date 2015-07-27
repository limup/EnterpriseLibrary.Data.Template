using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $rootnamespace$.Data.ResultSetMappers
{
    public class ResultSetSample : IResultSetMapper<string>
    {
        public IEnumerable<string> MapSet(System.Data.IDataReader reader)
        {
            List<string> retorno = new List<string>();

            try
            {
                while (reader.Read())
                {
                    //Classe variavel = new Classe();
                    //variavel.objeto = = reader["Campo"] == DBNull.Value ? String.Empty : reader["Campo"].ToString().Trim();
                    retorno.Add(reader["Sample"] == DBNull.Value ? string.Empty : reader["Sample"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
                System.GC.Collect();
            }

            return retorno;
        }
    }
}
