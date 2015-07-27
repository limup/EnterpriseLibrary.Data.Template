using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;

namespace UsandoEnterpriseLibraryDataTemplate.Data.ResultSetMappers
{
    public class ResultSetSample : IResultSetMapper<Model.Cliente>
    {
        public IEnumerable<Model.Cliente> MapSet(System.Data.IDataReader reader)
        {
            List<Model.Cliente> retorno = new List<Model.Cliente>();

            try
            {
                while (reader.Read())
                {
                    //Classe variavel = new Classe();
                    //variavel.objeto = = reader["Campo"] == DBNull.Value ? String.Empty : reader["Campo"].ToString().Trim();
                    Model.Cliente cliente = new Model.Cliente();

                    cliente.ClienteID = reader["ClienteID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["ClienteID"]);
                    cliente.Nome = reader["Nome"] == DBNull.Value ? string.Empty : reader["Nome"].ToString().Trim();
                    cliente.SobreNome = reader["SobreNome"] == DBNull.Value ? string.Empty : reader["SobreNome"].ToString().Trim();
                    cliente.Nascimento = reader["Nascimento"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["Nascimento"]);

                    retorno.Add(cliente);
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
