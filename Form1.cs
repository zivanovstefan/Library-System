using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka3
{
    public partial class Form1 : Form
    {
        List<Book> listaKnjiga = new List<Book>();

        public Form1()
        {
            InitializeComponent();
            dgKnjige.Columns.Add("nazivKnjige", "Naziv Knjige");
            dgKnjige.Columns.Add("imeAutora", "Ime Autora"); 
            dgKnjige.Columns.Add("isbnBroj", "ISBN");
            dgKnjige.Columns.Add("godinaIzdanja", "Godina Izdanja");
            dgKnjige.Columns.Add("brojStranica", "Broj Stranica");

            txtBrojStranica.Text = "0";

            dgKnjige.AllowUserToAddRows = false;
            dgKnjige.AllowUserToDeleteRows = false;
            dgKnjige.ReadOnly = true;
        }

        private void popuniTabelu()
        {
            dgKnjige.Rows.Clear();

            if(listaKnjiga.Count > 0)
            {
                foreach (Book instancaKnjige in listaKnjiga)
                {
                    dgKnjige.Rows.Add(instancaKnjige.NazivKnjige, instancaKnjige.ImeAutora,
                        instancaKnjige.IsbnBroj, instancaKnjige.GodinaIzdanja,
                        instancaKnjige.BrojStranica);
                }
            }
        }
        private void ponostiUnos()
        {
            txtNazivKnjige.Text = "";
            txtImeAutora.Text = "";
            txtIsbn.Text = "";
            txtBrojStranica.Text = "";
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                Book instancaKnjige = new Book();
                instancaKnjige.NazivKnjige = txtNazivKnjige.Text;
                instancaKnjige.ImeAutora = txtImeAutora.Text;
                instancaKnjige.IsbnBroj = txtIsbn.Text;
                instancaKnjige.GodinaIzdanja = dtDatumIzdavanja.Value.Year;
                instancaKnjige.BrojStranica = Convert.ToInt32(txtBrojStranica.Text);

                listaKnjiga.Add(instancaKnjige);

                popuniTabelu();
                ponostiUnos();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Prekoracenje opsega");
            }
            catch (FormatException)
            {
                MessageBox.Show("Pogresan format!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
