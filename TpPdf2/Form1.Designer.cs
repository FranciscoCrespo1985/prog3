namespace TpPdf2
{
    partial class Form1
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbxProgramer = new System.Windows.Forms.CheckBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rBtnHombre = new System.Windows.Forms.RadioButton();
            this.rBtnMujer = new System.Windows.Forms.RadioButton();
            this.lblSalida = new System.Windows.Forms.Label();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(34, 35);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(58, 17);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(393, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(591, 35);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbxProgramer
            // 
            this.cbxProgramer.AutoSize = true;
            this.cbxProgramer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxProgramer.Checked = true;
            this.cbxProgramer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxProgramer.Location = new System.Drawing.Point(37, 83);
            this.cbxProgramer.Name = "cbxProgramer";
            this.cbxProgramer.Size = new System.Drawing.Size(110, 21);
            this.cbxProgramer.TabIndex = 3;
            this.cbxProgramer.Text = "Programador";
            this.cbxProgramer.UseVisualStyleBackColor = true;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rBtnMujer);
            this.gbSexo.Controls.Add(this.rBtnHombre);
            this.gbSexo.Location = new System.Drawing.Point(37, 149);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(582, 100);
            this.gbSexo.TabIndex = 4;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rBtnHombre
            // 
            this.rBtnHombre.AutoSize = true;
            this.rBtnHombre.Checked = true;
            this.rBtnHombre.Location = new System.Drawing.Point(95, 41);
            this.rBtnHombre.Name = "rBtnHombre";
            this.rBtnHombre.Size = new System.Drawing.Size(76, 21);
            this.rBtnHombre.TabIndex = 0;
            this.rBtnHombre.TabStop = true;
            this.rBtnHombre.Text = "Hombre";
            this.rBtnHombre.UseVisualStyleBackColor = true;
            // 
            // rBtnMujer
            // 
            this.rBtnMujer.AutoSize = true;
            this.rBtnMujer.Location = new System.Drawing.Point(427, 41);
            this.rBtnMujer.Name = "rBtnMujer";
            this.rBtnMujer.Size = new System.Drawing.Size(61, 21);
            this.rBtnMujer.TabIndex = 0;
            this.rBtnMujer.Text = "Mujer";
            this.rBtnMujer.UseVisualStyleBackColor = true;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(46, 252);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(47, 17);
            this.lblSalida.TabIndex = 1;
            this.lblSalida.Text = "Salida";
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(49, 285);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSalida.Size = new System.Drawing.Size(476, 196);
            this.txtSalida.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 514);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.cbxProgramer);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "RadioButton y CheckBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox cbxProgramer;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rBtnMujer;
        private System.Windows.Forms.RadioButton rBtnHombre;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.TextBox txtSalida;
    }
}

