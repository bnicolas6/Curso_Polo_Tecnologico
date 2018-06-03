using System;
using System.Configuration;
using System.Web.Services;
using System.Web.Script.Serialization;
using Curso.Common.Interfaces;
using Curso.Common.Configuration;
using Curso.Common;

namespace Curso.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

 
        /////////////////////////////////////////////////////////LoginUser/////////////////////////////////////////////////////////
       
        [WebMethod(CacheDuration = 1, BufferResponse = false)]
        public static string LoginUser(string user,string password)
        {
            try
            {
                RequestResult oRequestResult = new RequestResult();
                using (IBusiness business = ((IBusiness)BusinessFactory.Instance.CreateBusiness(typeof(IBusiness), new object[] { })))
                {
                    oRequestResult.Authentication = (business.Login(user, password)) ? "Ok" : "Error";
                }
                return new JavaScriptSerializer().Serialize(oRequestResult);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /////////////////////////////////////////////////////////LostPassword/////////////////////////////////////////////////////////
        [WebMethod(CacheDuration = 1, BufferResponse = false)]
        public static string LostPassword(string email)
        {
            try
            {
                RequestResult oRequestResult = new RequestResult();
                using (IBusiness business = ((IBusiness)BusinessFactory.Instance.CreateBusiness(typeof(IBusiness), new object[] { })))
                {
                    oRequestResult.Authentication = (business.LostPassword(email)) ? "Ok" : "Error";
                }
                return new JavaScriptSerializer().Serialize(oRequestResult);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /////////////////////////////////////////////////////////RegisterUser/////////////////////////////////////////////////////////
        [WebMethod(CacheDuration = 1, BufferResponse = false)]
        public static string RegisterUser(string user, string email, string password)
        {
            try
            {
                RequestResult oRequestResult = new RequestResult();
                using (IBusiness business = ((IBusiness)BusinessFactory.Instance.CreateBusiness(typeof(IBusiness), new object[] { })))
                {
                    oRequestResult.Authentication = (business.Register(user, email, password)) ? "Ok" : "Error";
                }
                return new JavaScriptSerializer().Serialize(oRequestResult);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /////////////////////////////////////////////////////////ChangePassword/////////////////////////////////////////////////////////
        [WebMethod(CacheDuration = 1, BufferResponse = false)]
        public static string ChangePassword(string email, string code, string password)
        {
            try
            {
                RequestResult oRequestResult = new RequestResult();
                using (IBusiness business = ((IBusiness)BusinessFactory.Instance.CreateBusiness(typeof(IBusiness), new object[] { })))
                {
                    oRequestResult.Authentication = (business.changePassword(email, code, password)) ? "Ok" : "Error";
                }
                return new JavaScriptSerializer().Serialize(oRequestResult);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}