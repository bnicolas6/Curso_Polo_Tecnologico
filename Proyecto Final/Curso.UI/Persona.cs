using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Curso.UI
{
    public class Persona
    {
        private string _name;
        private string _surname;
        private string _phone;

        public Persona(string name, string surname, string phone)
        {
            _name = name;
            _surname = surname;
            _phone = phone;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }
}