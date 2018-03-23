using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Curso.UI
{
    public class RequestResult
    {
        private string _authentication;

        public string Authentication {
            get { return _authentication; }
            set { _authentication = value; }
        }
    }
}