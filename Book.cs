using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka3
{
    class Book
    {
        private string nazivKnjige;
        private string imeAutora;
        private string isbnBroj;
        private int godinaIzdanja;
        private int brojStranica;

        public Book() { }

        public string NazivKnjige
        {
            get { return nazivKnjige; }
            set
            {
                nazivKnjige = value;
                if (nazivKnjige == "")
                {
                    Exception ex = new Exception("Morate uneti naziv knjige!");
                    throw ex;
                }
            }
        }
        public string ImeAutora
        {
            get { return imeAutora; }
            set
            {
                imeAutora = value;
                if (imeAutora == "")
                {
                    Exception ex = new Exception("Morate uneti ime autora!");
                    throw ex;
                }
            }
        }
        public string IsbnBroj
        {
            get { return isbnBroj; }
            set
            {
                isbnBroj = value;
                if (isbnBroj == "")
                {
                    Exception ex = new Exception("Morate uneti ISBN!");
                    throw ex;
                }
            }
        }
        public int GodinaIzdanja
        {
            get { return godinaIzdanja; }
            set
            {
                godinaIzdanja = value;
            }
        }
        public int BrojStranica
        {
            get { return brojStranica; }
            set
            {
                brojStranica = value;
            }
        }


    }
}
