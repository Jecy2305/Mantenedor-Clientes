using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CapaLogica;
using CapaEntidad;

namespace Mantenedor_Clientes
{
    public partial class FormMantenedorCliente : Form
    {
        public FormMantenedorCliente()
        {
            InitializeComponent();
            ListarCliente();
            LlenarCboxCiudad();
        }

        private void LimpiarVariables()
        {
            txtRazonSocial.Text = "";
            txtRucCliente.Text = "";
            txtTipoCliente.Text = "";
        }

        public void ListarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            txtCliente.Clear();
            LimpiarVariables();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entCliente c = new entCliente();
                c.razonSocial = txtRazonSocial.Text.Trim();
                c.idTipoCliente = int.Parse(txtTipoCliente.Text.Trim());
                c.rucCliente = txtRucCliente.Text.Trim();
                c.fecRegCliente = dtPickerRegCliente.Value;
                c.idCiudad = int.Parse(cboCiudad.Text.Trim());
                c.estCliente = cbkEstadoCliente.Checked; 
                logCliente.Instancia.InsertaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            ListarCliente();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true; 
            btnModificar.Visible = true; 
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try {
                entCliente c = new entCliente();
                c.idCliente = int.Parse(txtCliente.Text.Trim());
                c.razonSocial = txtRazonSocial.Text.Trim();
                c.rucCliente = txtRucCliente.Text.Trim();
                c.idTipoCliente = int.Parse(txtTipoCliente.Text.Trim());
                c.fecRegCliente = dtPickerRegCliente.Value;
                c.idCiudad = int.Parse(cboCiudad.Text.Trim());
                c.estCliente = cbkEstadoCliente.Checked;
                logCliente.Instancia.EditaCliente(c);
            } catch (Exception ex) {
                MessageBox.Show("Error.." + ex); 
            }
            LimpiarVariables(); 
            groupBoxDatos.Enabled = false;
            ListarCliente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente(); 
                c.idCliente = int.Parse(txtCliente.Text.Trim()); 
                logCliente.Instancia.DeshabilitarCliente(c);
            }
            catch (Exception ex) {
                MessageBox.Show("Error.." + ex); 
            }
            LimpiarVariables(); 
            groupBoxDatos.Enabled = false; 
            ListarCliente();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex];
            txtCliente.Text = filaActual.Cells[0].Value.ToString();
            txtRazonSocial.Text = filaActual.Cells[1].Value.ToString();
            txtRucCliente.Text = filaActual.Cells[2].Value.ToString();
            txtTipoCliente.Text = filaActual.Cells[3].Value.ToString();
            dtPickerRegCliente.Text = filaActual.Cells[4].Value.ToString();
            cboCiudad.Text = filaActual.Cells[5].Value.ToString();
            cbkEstadoCliente.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
        }

        public void LlenarCboxCiudad()
        {
            cboCiudad.DataSource = logCiudad.Instancia.ListarIdCiudad();
        }
    }
}

