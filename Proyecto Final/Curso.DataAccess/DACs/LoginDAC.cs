using System;
using System.Data;
using Curso.Common.DTOs;
using Curso.Common;
using System.Reflection;

namespace Curso.DataAccess.DACs
{
    public class LoginDAC : SQLBaseDAC
    {
        #region --Attributes--

        private static readonly string _classFullName = MethodBase.GetCurrentMethod().DeclaringType.ToString();

        #endregion --Attributes--

        public LoginDAC()
        {
            base.OpenConnection();
        }

        public User getUser(string user)
        {
            User oUser = null;
            IDataReader oReader = null;
            using (IDbCommand oCommand = base.GetCommand())
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.CommandText = "sp_getUser";

                IDbDataParameter oParam0 = (IDbDataParameter)oCommand.CreateParameter();
                oParam0.ParameterName = "@Usuario";
                oParam0.DbType = DbType.AnsiString;
                oParam0.Value = user;
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
                    Logging.Instance.LogError(_classFullName + ".getUser(string user) -> " + ex.Message.ToString(), ex);
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
    }
}
