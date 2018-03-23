using Curso.Common.Interfaces;
using System;
using Curso.DataAccess.DACs;
using Curso.Common.DTOs;

namespace Curso.Business
{
    public class Business : IBusiness
    {
        public Business(object[] args)
        {
        }

        public void Dispose()
        {
        }

        public bool Login(string user, string password)
        {
            if (String.IsNullOrEmpty(user))
                return false;

            User oUser = (new LoginDAC()).getUser(user); 
            return (password == oUser.Password);
        }


        public bool LostPassword(string email)
        {
            if (String.IsNullOrEmpty(email))
                return false;
            User oUser = (new LostPasswordDAC()).getEmail(email);
            return EmailSending.send(email, oUser.Password);

            //throw new NotImplementedException();
        }

        public bool Register(string user, string email, string password)
        {
            return ((new RegisterDAC()).insertUser(user, email, password) > 0);
        }
    }
}
