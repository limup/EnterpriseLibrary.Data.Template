using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $rootnamespace$.Data.ParameterMappers
{
    public class ParameterMapperSample : IParameterMapper
    {
        public void AssignParameters(System.Data.Common.DbCommand command, object[] parameterValues)
        {
            DbParameter CodSampleID = command.CreateParameter();
            CodSampleID.Value = parameterValues[0];
            CodSampleID.ParameterName = "@CodSampleID";

            command.Parameters.Add(CodSampleID);
        }
    }
}
