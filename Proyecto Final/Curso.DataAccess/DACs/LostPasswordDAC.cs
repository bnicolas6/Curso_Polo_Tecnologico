using System;
using System.Data;
using Curso.Common.DTOs;
using Curso.Common;
using System.Reflection;


namespace Curso.DataAccess.DACs
{
    public class LostPasswordDAC : SQLBaseDAC
    {
        #region --Attributes--

        private static readonly string _classFullName = MethodBase.GetCurrentMethod().DeclaringType.ToString();
 
        #endregion --Attributes--

        public LostPasswordDAC() 
        {
            base.OpenConnection();
        }

        public User getEmail(string email)
        {
            User oUser = null;
            IDataReader oReader = null;
            using (IDbCommand oCommand = base.GetCommand())
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.CommandText = "sp_getEmail";

                IDbDataParameter oParam0 = (IDbDataParameter)oCommand.CreateParameter();
                oParam0.ParameterName = "@Email";
                oParam0.DbType = DbType.AnsiString;
                oParam0.Value = email;
                oCommand.Parameters.Add(oParam0);

                try
                {
                    oReader = oCommand.ExecuteReader();
                    oUser = new User();
                    while (oReader.Read())
                    {
                        oUser.Email = oReader[oReader.GetOrdinal("Email")].ToString();
                        oUser.Usuario = oReader[oReader.GetOrdinal("Usuario")].ToString();
                        oUser.Password = oReader[oReader.GetOrdinal("Password")].ToString();
                    }
                    base.CloseCommand();
                }
                catch (System.Exception ex)
                {
                    Logging.Instance.LogError(_classFullName + ".getEmail(string email) -> " + ex.Message.ToString(), ex);
                }
                finally
                {
                    if (oReader != null)
                    {
                        oReader.Close();
                        //oReader.Dispose();
                        oReader = null;
                    }
                }
            }
            return oUser;
        }

        public int updateUser(string email, string password)
        {
            int result = 0;

            using (IDbCommand oCommand = base.GetCommand())
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.CommandText = "sp_updateUser";

                IDbDataParameter oParam0 = (IDbDataParameter)oCommand.CreateParameter();
                oParam0.ParameterName = "@Email";
                oParam0.DbType = DbType.AnsiString;
                oParam0.Value = email;
                oCommand.Parameters.Add(oParam0);

                IDbDataParameter oParam1 = (IDbDataParameter)oCommand.CreateParameter();
                oParam1.ParameterName = "@Password";
                oParam1.DbType = DbType.AnsiString;
                oParam1.Value = password;
                oCommand.Parameters.Add(oParam1);

                try
                {
                    result = oCommand.ExecuteNonQuery();
                    //Si el PROCEDURE afectado tiene la linea "SET NOCOUNT ON": Si no ocurre ningun error y hace un INSERT, ExecuteNonQuery() devolvera -1, de lo contrario no devuelve ningun valor numerico.
                    //                       si lo cambio por "SET NOCOUNT OFF": Si no ocurre ningun error y hace un INSERT, ExecuteNonQuery() devolvera la cantidad de registros afectados (1) de lo contrario no devuelve ningun valor numerico.
                    base.CloseCommand();
                }
                catch (System.Exception ex) //Si no lo puede hacer INSERT, lanza una excepcion
                {
                    Logging.Instance.LogError(_classFullName + ".insertUser(string user, string email, string password) -> " + ex.Message.ToString(), ex);
                }

            }
            return result;
        }
    }
}
