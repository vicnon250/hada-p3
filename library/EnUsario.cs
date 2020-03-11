using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ENUsario
    {
        private string nif, nombre;
        private int edad;
        public ENUsario()
        {

        }
        public ENUsario(string Nif,string Nombre,int Edad)
        {
            nif = Nif;
            nombre = Nombre;
            edad=Edad;
        }
        public bool readUsario()
        {
            return true;
        }
        public bool readFirstUsario()
        {
            return true;
        }
        public bool readNextUsario()
        {
            return true;
        }
        public bool readPrevUsario()
        {
            return true;
        }
        public bool updateUsario()
        {
            return true;
        }
        public bool deleteUsario()
        {
            return true;
        }
    }
}
