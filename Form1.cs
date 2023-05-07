using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMedicamentos
{
    public partial class frmgmedicamentos : Form
    {
        public frmgmedicamentos()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Codigo Valido", this.Text);
                return;
            }

            if (txtnombre.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Nombre Valido", this.Text);
                return;
            }

            if (txtcantidad.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Cantidad Valida", this.Text);
                return;
            }

            if (txtprecioUnitario.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Precio Valido", this.Text);
                return;
            }

            Medicamento medicamento = new Medicamento();
            medicamento.s_codigo = txtcodigo.Text;
            medicamento.s_nombre = txtnombre.Text;
            medicamento.s_cantidad = int.Parse(txtcantidad.Text);
            medicamento.s_precioUnit = float.Parse(txtprecioUnitario.Text);

            float s_montinvertido = 0;
            s_montinvertido = medicamento.s_precioUnit * medicamento.s_cantidad;

            int s_rowUndex = dgvdatos.Rows.Add();

            dgvdatos.Rows[s_rowUndex].Cells[0].Value = medicamento.s_codigo;
            dgvdatos.Rows[s_rowUndex].Cells[1].Value = medicamento.s_nombre;
            dgvdatos.Rows[s_rowUndex].Cells[2].Value = medicamento.s_cantidad;
            dgvdatos.Rows[s_rowUndex].Cells[3].Value = medicamento.s_precioUnit.ToString();
            dgvdatos.Rows[s_rowUndex].Cells[4].Value = s_montinvertido.ToString();

            //Limpiamos los objetos
            txtcodigo.Clear();
            txtnombre.Clear();
            txtcantidad.Clear();
            txtprecioUnitario.Clear();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "") {
                MessageBox.Show("Debe Ingresar un Nombre de Medicamento a buscar", this.Text );
                return;
            }

            if (dgvdatos.Rows.Count <= 0)
            {
                MessageBox.Show("No Existe Data para realizar la Busqueda", this.Text);
                return;
            }

            string s_buscarnombre = txtnombre.Text;
            bool s_encontrado = false;
            int s_columna = 1;
            // Recorremos todas las filas del DataGridView
            foreach (DataGridViewRow s_fila in dgvdatos.Rows)
            {
                string valorCelda = s_fila.Cells[s_columna].Value.ToString();

                if (valorCelda.Contains(s_buscarnombre))
                {
                    s_encontrado = true;
                    s_fila.Selected = true;
                    break;
                }
            }

            if (s_encontrado)
            {
                MessageBox.Show("Dato Encontrado!", this.Text); 
            }
            else
            {
                MessageBox.Show("Dato No Encontrado!", this.Text);
            }

        }

        private void frmgmedicamentos_Load(object sender, EventArgs e)
        {
        }

        //Creando el metodo de ordenamiento
        private void Ordenar(DataGridView dataGridView)
        {
            int n = dataGridView.Rows.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    string n1 = dataGridView.Rows[j].Cells["Nombre"].Value.ToString();
                    string n2 = dataGridView.Rows[j + 1].Cells["Nombre"].Value.ToString();
                    if (n1.CompareTo(n2) > 0)
                    {
                        // Intercambiar las filas
                        DataGridViewRow tempRow = dataGridView.Rows[j];
                        //dataGridView.Rows[j] = dataGridView.Rows[j + 1];
                        //dataGridView.Rows[j + 1] = tempRow;
                    }
                }
            }
        }

        private void btnordenar_Click(object sender, EventArgs e)
        {
            //Ordenar(dgvdatos);
            DataGridViewColumn columna = dgvdatos.Columns["Nombre"];
            columna.SortMode = DataGridViewColumnSortMode.Automatic;
            dgvdatos.Sort(columna, ListSortDirection.Ascending);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvdatos.Rows.Count > 0)
            { 
                string s_buscarcodigo = txtcodigo.Text;
                int s_columna = 0;

            // Recorremos todas las filas del DataGridView
                foreach (DataGridViewRow s_fila in dgvdatos.Rows)
                {
                    string valorCelda = s_fila.Cells[s_columna].Value.ToString();

                    if (valorCelda.Contains(s_buscarcodigo))
                    {
                        dgvdatos.Rows.RemoveAt(s_fila.Index);
                        txtcodigo.Clear();
                        break;
                    }
                }   
             }
        }

    }
}
