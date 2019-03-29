namespace TpPdf2RichText
{
    partial class frmRichTextBox
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
            this.btnNegrita = new System.Windows.Forms.Button();
            this.btnSubrayado = new System.Windows.Forms.Button();
            this.btnCursiva = new System.Windows.Forms.Button();
            this.btnCentrado = new System.Windows.Forms.Button();
            this.lbSize = new System.Windows.Forms.Label();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.rtxteditor = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNegrita
            // 
            this.btnNegrita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNegrita.Location = new System.Drawing.Point(71, 40);
            this.btnNegrita.Name = "btnNegrita";
            this.btnNegrita.Size = new System.Drawing.Size(75, 23);
            this.btnNegrita.TabIndex = 0;
            this.btnNegrita.Text = "&Negrita";
            this.btnNegrita.UseVisualStyleBackColor = true;
            this.btnNegrita.Click += new System.EventHandler(this.btnNegrita_Click);
            // 
            // btnSubrayado
            // 
            this.btnSubrayado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubrayado.Location = new System.Drawing.Point(190, 40);
            this.btnSubrayado.Name = "btnSubrayado";
            this.btnSubrayado.Size = new System.Drawing.Size(75, 23);
            this.btnSubrayado.TabIndex = 0;
            this.btnSubrayado.Text = "&Subrayado";
            this.btnSubrayado.UseVisualStyleBackColor = true;
            this.btnSubrayado.Click += new System.EventHandler(this.btnSubrayado_Click);
            // 
            // btnCursiva
            // 
            this.btnCursiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCursiva.Location = new System.Drawing.Point(374, 40);
            this.btnCursiva.Name = "btnCursiva";
            this.btnCursiva.Size = new System.Drawing.Size(75, 23);
            this.btnCursiva.TabIndex = 0;
            this.btnCursiva.Text = "C&ursiva";
            this.btnCursiva.UseVisualStyleBackColor = true;
            this.btnCursiva.Click += new System.EventHandler(this.btnCursiva_Click);
            // 
            // btnCentrado
            // 
            this.btnCentrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCentrado.Location = new System.Drawing.Point(509, 40);
            this.btnCentrado.Name = "btnCentrado";
            this.btnCentrado.Size = new System.Drawing.Size(75, 23);
            this.btnCentrado.TabIndex = 0;
            this.btnCentrado.Text = "&entrado";
            this.btnCentrado.UseVisualStyleBackColor = true;
            this.btnCentrado.Click += new System.EventHandler(this.btnCentrado_Click);
            // 
            // lbSize
            // 
            this.lbSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(190, 104);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(27, 13);
            this.lbSize.TabIndex = 1;
            this.lbSize.Text = "Size";
            // 
            // txtTamanio
            // 
            this.txtTamanio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTamanio.Location = new System.Drawing.Point(223, 104);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(100, 20);
            this.txtTamanio.TabIndex = 2;
            this.txtTamanio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamanio_KeyPress);
            this.txtTamanio.Validated += new System.EventHandler(this.txtTamanio_Validated);
            // 
            // rtxteditor
            // 
            this.rtxteditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxteditor.Location = new System.Drawing.Point(12, 210);
            this.rtxteditor.Name = "rtxteditor";
            this.rtxteditor.Size = new System.Drawing.Size(746, 305);
            this.rtxteditor.TabIndex = 3;
            this.rtxteditor.Text = "";
            this.rtxteditor.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtxteditor_LinkClicked);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.Location = new System.Drawing.Point(574, 576);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAbrir.Location = new System.Drawing.Point(683, 576);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "&Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // frmRichTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 642);
            this.Controls.Add(this.rtxteditor);
            this.Controls.Add(this.txtTamanio);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.btnCentrado);
            this.Controls.Add(this.btnCursiva);
            this.Controls.Add(this.btnSubrayado);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNegrita);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "frmRichTextBox";
            this.Text = "RichTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNegrita;
        private System.Windows.Forms.Button btnSubrayado;
        private System.Windows.Forms.Button btnCursiva;
        private System.Windows.Forms.Button btnCentrado;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.RichTextBox rtxteditor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAbrir;
    }
}

