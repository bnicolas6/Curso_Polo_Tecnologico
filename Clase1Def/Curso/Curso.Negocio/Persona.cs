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
     }
}