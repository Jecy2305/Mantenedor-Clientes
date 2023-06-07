
namespace Mantenedor_Clientes
{
    partial class FormCiudad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCiudad = new System.Windows.Forms.DataGridView();
            this.btnAgregarCiudad = new System.Windows.Forms.Button();
            this.cbkEstadoCiudad = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesCiudad = new System.Windows.Forms.TextBox();
            this.btnModificarCiudad = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCiudad
            // 
            this.dgvCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCiudad.Location = new System.Drawing.Point(12, 12);
            this.dgvCiudad.Name = "dgvCiudad";
            this.dgvCiudad.Size = new System.Drawing.Size(343, 260);
            this.dgvCiudad.TabIndex = 0;
            this.dgvCiudad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCiudad_CellClick);
            // 
            // btnAgregarCiudad
            // 
            this.btnAgregarCiudad.Location = new System.Drawing.Point(382, 256);
            this.btnAgregarCiudad.Name = "btnAgregarCiudad";
            this.btnAgregarCiudad.Size = new System.Drawing.Size(118, 48);
            this.btnAgregarCiudad.TabIndex = 1;
            this.btnAgregarCiudad.Text = "Agregar";
            this.btnAgregarCiudad.UseVisualStyleBackColor = true;
            this.btnAgregarCiudad.Click += new System.EventHandler(this.btnAgregarCiudad_Click);
            // 
            // cbkEstadoCiudad
            // 
            this.cbkEstadoCiudad.AutoSize = true;
            this.cbkEstadoCiudad.Checked = true;
            this.cbkEstadoCiudad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkEstadoCiudad.Font = new System.Drawing.Font("Arial", 9F);
            this.cbkEstadoCiudad.Location = new System.Drawing.Point(247, 310);
            this.cbkEstadoCiudad.Name = "cbkEstadoCiudad";
            this.cbkEstadoCiudad.Size = new System.Drawing.Size(108, 19);
            this.cbkEstadoCiudad.TabIndex = 5;
            this.cbkEstadoCiudad.Text = "Estado Ciudad";
            this.cbkEstadoCiudad.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.Location = new System.Drawing.Point(12, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ciudad:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Enabled = false;
            this.txtCiudad.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCiudad.Location = new System.Drawing.Point(94, 311);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(76, 23);
            this.txtCiudad.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.Location = new System.Drawing.Point(12, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Descripcion:";
            // 
            // txtDesCiudad
            // 
            this.txtDesCiudad.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDesCiudad.Location = new System.Drawing.Point(94, 359);
            this.txtDesCiudad.Name = "txtDesCiudad";
            this.txtDesCiudad.Size = new System.Drawing.Size(142, 23);
            this.txtDesCiudad.TabIndex = 17;
            // 
            // btnModificarCiudad
            // 
            this.btnModificarCiudad.Location = new System.Drawing.Point(382, 324);
            this.btnModificarCiudad.Name = "btnModificarCiudad";
            this.btnModificarCiudad.Size = new System.Drawing.Size(118, 48);
            this.btnModificarCiudad.TabIndex = 19;
            this.btnModificarCiudad.Text = "Modificar";
            this.btnModificarCiudad.UseVisualStyleBackColor = true;
            this.btnModificarCiudad.Click += new System.EventHandler(this.btnModificarCiudad_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(382, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 48);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(382, 184);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(118, 48);
            this.btnDeshabilitar.TabIndex = 21;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // FormCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificarCiudad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesCiudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.cbkEstadoCiudad);
            this.Controls.Add(this.btnAgregarCiudad);
            this.Controls.Add(this.dgvCiudad);
            this.Name = "FormCiudad";
            this.Text = "FormCiudad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCiudad;
        private System.Windows.Forms.Button btnAgregarCiudad;
        private System.Windows.Forms.CheckBox cbkEstadoCiudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesCiudad;
        private System.Windows.Forms.Button btnModificarCiudad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDeshabilitar;
    }
}