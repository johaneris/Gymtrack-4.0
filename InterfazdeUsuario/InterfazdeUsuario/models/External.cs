using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazdeUsuario.models
{
    internal class External
    {
        public string Name { get; set; }   
        public string Cedula { get; set; }  
        public string Email { get; set; }

        //Crear constructor
        public External(string name, string cedula, string email)
        {
            Name = name;
            Cedula = cedula;
            Email = email;
        }
    }
}
