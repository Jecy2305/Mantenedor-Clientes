using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenedor_Clientes
{
    public partial class FormCiudad : Form
    {
        public FormCiudad()
        {
            InitializeComponent();
            ListarCiudad();
        }

        public void ListarCiudad()
        {
            dgvCiudad.DataSource = logCiudad.Instancia.ListarCiudad();
        }

        private void btnAgregarCiudad_Click(object sender, EventArgs e)
        {
            try
            {
                entCiudad c = new entCiudad();
                c.desCiudad = txtDesCiudad.Text.Trim();
                c.estCiudad = cbkEstadoCiudad.Checked;
                logCiudad.Instancia.InsertaCiudad(c);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarCiudad();
        }

        private void dgvCiudad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCiudad.Rows[e.RowIndex];
            txtCiudad.Text = filaActual.Cells[0].Value.ToString();
            txtDesCiudad.Text = filaActual.Cells[1].Value.ToString();
            cbkEstadoCiudad.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }

        private void btnModificarCiudad_Click(object sender, EventArgs e)
        {
            try
            {
                entCiudad c = new entCiudad();
                c.idCiudad = int.Parse(txtCiudad.Text.Trim());
                c.desCiudad = txtDesCiudad.Text.Trim();
                c.estCiudad = cbkEstadoCiudad.Checked;
                logCiudad.Instancia.EditarCiudad(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarCiudad();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCiudad c = new entCiudad();
                c.idCiudad = int.Parse(txtCiudad.Text.Trim());
                logCiudad.Instancia.DeshabilitarCiudad(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            ListarCiudad();
        }
    }
}
