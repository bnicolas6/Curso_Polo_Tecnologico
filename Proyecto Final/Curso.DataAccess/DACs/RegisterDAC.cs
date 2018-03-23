using System;
using System.Data;
using Curso.Common.DTOs;
using Curso.Common;
using System.Reflection;


namespace Curso.DataAccess.DACs
{
    public class RegisterDAC : SQLBaseDAC
    {

        #region --Atributes--

        private static readonly string _classFullName = MethodBase.GetCurrentMethod().DeclaringType.ToString(); 

        #endregion --Attributes--

       
        public RegisterDAC()
        {
            base.OpenConnection();
        }

        public int insertUser(string user, string email, string password)
        {
            int cantFilas = 0;

            using (IDbCommand oCommand = base.GetCommand())
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.CommandText = "sp_insertUser";

                IDbDataParameter oParam0 = (IDbDataParameter)oCommand.CreateParameter();
                oParam0.ParameterName = "@Email";
                oParam0.DbType = DbType.AnsiString;
                oParam0.Value = email;
                oCommand.Parameters.Add(oParam0);

                IDbDataParameter oParam1 = (IDbDataParameter)oCommand.CreateParameter();
                oParam1.ParameterName = "@Usuario";
                oParam1.DbType = DbType.AnsiString;
                oParam1.Value = user;
                oCommand.Parameters.Add(oParam1);

                IDbDataParameter oParam2 = (IDbDataParameter)oCommand.CreateParameter();
                oParam2.ParameterName = "@Password";
                oParam2.DbType = DbType.AnsiString;
                oParam2.Value = password;
                oCommand.Parameters.Add(oParam2);

                try
                {
                    cantFilas = oCommand.ExecuteNonQuery();
                    //Si el PROCEDURE afectado tiene la linea "SET NOCOUNT ON": Si no ocurre ningun error y hace un INSERT, ExecuteNonQuery() devolvera -1, de lo contrario no devuelve ningun valor numerico.
                    //                       si lo cambio por "SET NOCOUNT OFF": Si no ocurre ningun error y hace un INSERT, ExecuteNonQuery() devolvera la cantidad de registros afectados (1) de lo contrario no devuelve ningun valor numerico.
                    base.CloseCommand();
                }
                catch (System.Exception ex) //Si no lo puede hacer INSERT, lanza una excepcion
                {
                    Logging.Instance.LogError(_classFullName + ".insertUser(string user, string email, string password) -> " + ex.Message.ToString(), ex);
                }

            }
            return cantFilas;
        }
    }
}
