using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace UsandoEnterpriseLibraryDataTemplate.Data
{
    public class ClassManipulation : BaseData
    {
        public List<Model.Cliente> ObterDados(int CodSampleID)
        {
            #region Query

            string query = @"SELECT * 
                             FROM Cliente
                             WHERE ClienteID = @CodSampleID";

            #endregion

            try
            {
                var accessor = database.CreateSqlStringAccessor<Model.Cliente>(query, new ParameterMappers.ParameterMapperSample(),
                                                                               new ResultSetMappers.ResultSetSample());
                return accessor.Execute(CodSampleID).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
