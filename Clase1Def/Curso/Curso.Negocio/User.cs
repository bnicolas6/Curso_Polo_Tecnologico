using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Negocio
{

    public class Persona {
        private string name;
        private string surname;
        private int age;
        private int dni;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public Persona(string name, string surname, int age, int dni) {
            Name = name;
            Surname = surname;
            Age = age;
            Dni = dni;
        }
        
    
    
    
    }
    public class User:Persona{

        private string username;
        private string password;

        public string Username{
            get { return username; }
            set { username = value; }
        }
        public string Password{
            get { return password; }
            set { password = value; }
        }

        public User(string username, string password) : base(null,null,0,0){
            Username = username;
            Password = password;
        }

        public string toString() {
            return "Username: " + username + " Password: " + password;
        }

        public bool verificarLogin() {
            return (username.Length > 4 && password.Length > 9 && verificarMayus() == true) ? true : false;
        }

        private bool verificarMayus() {
            return (Buscar.buscarMayus(username) == true && Buscar.buscarMayus(password) == true) ? true : false;
        }
    }

    static class Buscar {

        public static bool buscarMayus(string cadena) {
            bool valor = false;
            int i=0;
          
            while (i < cadena.Length && valor == false) {
                if (cadena[i] >= 'A' && cadena[i] <= 'Z')
                    valor = true;
                i++;
            }
            return valor;
        }
    }
}
