using Curso.Common.Interfaces;
using System;
using Curso.DataAccess.DACs;
using Curso.Common.DTOs;

namespace Curso.Business
{
    public class Business : IBusiness{

        //private RandomCodeGenerator generator = new RandomCodeGenerator();
        private static string _code;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        public Business(object[] args){}
        public void Dispose(){}

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
            //generator = new RandomCodeGenerator();
            RandomCodeGenerator generator = new RandomCodeGenerator();
            _code = generator.Code;
            return EmailSending.send(email, _code);
        }

        public bool changePassword(string email, string code, string password){
            if (code != _code)
                return false;
            return ((new LostPasswordDAC()).updateUser(email, password) == -1);
        }

        public bool Register(string user, string email, string password)
        {
            return ((new RegisterDAC()).insertUser(user, email, password) == -1);
        }


        
    }
}
