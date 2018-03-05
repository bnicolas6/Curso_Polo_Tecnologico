using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Negocio
{
     public class Persona
    {
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

        public Persona(string name, string surname, int age, int dni)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Dni = dni;
        }

       //Cosas Nuevas

        //public virtual bool verificarLogin(){return false;} //Una forma
        public virtual bool verificarLogin() { //Otra forma
            throw new NotImplementedException();
        }
        protected bool verificarLogin2() { 
            throw new Exception("Validar 2 de Persona");
        }

         ///En validar2 en public es accedido por sus hijos
         ///En public probado por user2, no hay problema, pero con protected no
         ///Lo mismo pasa con User, si esta protegido en Persona, no puedo acceder
         ///ni desde persona
         ///Privado no se ve en herencia
         ///SI TENGO ALGO COMO PROTECTED LO VE LA CLASE QUE HEREDA
        
   
        



    }



}
