using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practo_Listas
{
    public partial class Form1 : Form
    {
        List<string> listAnimales;
        public Form1()
        {
            InitializeComponent();

        }
        #region "Metodos_Propios"
        private void mostrar()
        {
            lbAnimales.Items.Clear();
            foreach (string nombre in listAnimales)
            {
                lbAnimales.Items.Add(nombre);
            }
        }
        private void actualizar()
        {
            if (cbOrdenado.Checked)
            { listAnimales.Sort(); }
            mostrar();
            lCantAnimales.Text = "Cantidad de Animales: " + listAnimales.Count();
            lCapLista.Text = "Capacidad de la lista: " + listAnimales.Capacity.ToString() ;
        }

        #endregion
        private void bAgregar_Click(object sender, EventArgs e)
        {
            string nombre = tbAnimales.Text.Trim().ToUpper();
            if (nombre == "")
            {
                MessageBox.Show("Falta escribir nombre del animal", "Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (listAnimales.Contains(nombre))
            {
                int posicion = listAnimales.IndexOf(nombre) + 1;
                MessageBox.Show("El animal ya se encuentra en la lista, en la posicion: " + posicion.ToString(), "Animal", MessageBoxButtons.OK);
            }
            else if (cbOrdenado.Checked || listAnimales.Count == 0)
            {
                listAnimales.Add(nombre);
                tbAnimales.Clear();
                actualizar();
            }
            else 
            {
                DialogResult resp;
                resp = MessageBox.Show("Quiere insertarlo primero?", "Animales", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resp == DialogResult.Yes)
                {
                    listAnimales.Insert(0, nombre);
                    tbAnimales.Clear();

                }
                else
                {
                    listAnimales.Add(nombre);
                    tbAnimales.Clear();
                }
                actualizar();
                
                   
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listAnimales = new List<string>();
            actualizar();

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbOrdenado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOrdenado.Checked)
            {
                listAnimales.Sort();
                mostrar();
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            
            if (lbAnimales.SelectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado ningun animal", "Animal", MessageBoxButtons.OK);

            }
            else 
            {
                DialogResult resp;
                resp = MessageBox.Show("Esta seguro que desea eliminarlo","Animal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resp == DialogResult.Yes)
                {
                    listAnimales.Remove(lbAnimales.SelectedItem.ToString());
                    actualizar();
                }
            }
        }
    }
}
