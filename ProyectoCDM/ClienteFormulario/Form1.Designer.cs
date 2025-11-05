namespace ClienteFormulario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            label2 = new Label();
            lblDe = new Label();
            lblhacia = new Label();
            lblMonto = new Label();
            lblTasa = new Label();
            lblResultado = new Label();
            lblFecha = new Label();
            cmbDe = new ComboBox();
            cmbHacia = new ComboBox();
            txtMonto = new TextBox();
            btnConvertir = new Button();
            btnConvertir.Click += btnConvertir_Click;
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(175, 69);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Conversor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 121);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // lblDe
            // 
            lblDe.AutoSize = true;
            lblDe.Location = new Point(24, 78);
            lblDe.Name = "lblDe";
            lblDe.Size = new Size(78, 15);
            lblDe.TabIndex = 2;
            lblDe.Text = "Convertir de: ";
            // 
            // lblhacia
            // 
            lblhacia.AutoSize = true;
            lblhacia.Location = new Point(24, 121);
            lblhacia.Name = "lblhacia";
            lblhacia.Size = new Size(71, 15);
            lblhacia.TabIndex = 3;
            lblhacia.Text = "Convertir a: ";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(24, 172);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(46, 15);
            lblMonto.TabIndex = 4;
            lblMonto.Text = "Monto:";
            // 
            // lblTasa
            // 
            lblTasa.AutoSize = true;
            lblTasa.Location = new Point(24, 336);
            lblTasa.Name = "lblTasa";
            lblTasa.Size = new Size(67, 15);
            lblTasa.TabIndex = 5;
            lblTasa.Text = "Tasa usada:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(24, 275);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(24, 378);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha:";
            // 
            // cmbDe
            // 
            cmbDe.FormattingEnabled = true;
            cmbDe.Items.AddRange(new object[] { "USD", "EUR" });
            cmbDe.Location = new Point(108, 75);
            cmbDe.Name = "cmbDe";
            cmbDe.Size = new Size(121, 23);
            cmbDe.TabIndex = 9;
            // 
            // cmbHacia
            // 
            cmbHacia.FormattingEnabled = true;
            cmbHacia.Items.AddRange(new object[] { "USD", "EUR" });
            cmbHacia.Location = new Point(108, 118);
            cmbHacia.Name = "cmbHacia";
            cmbHacia.Size = new Size(121, 23);
            cmbHacia.TabIndex = 10;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(108, 169);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(206, 23);
            txtMonto.TabIndex = 11;
            txtMonto.Text = "Ingresar Cantidad";
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = SystemColors.ActiveCaption;
            btnConvertir.Location = new Point(130, 213);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(115, 39);
            btnConvertir.TabIndex = 12;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 450);
            Controls.Add(btnConvertir);
            Controls.Add(txtMonto);
            Controls.Add(cmbHacia);
            Controls.Add(cmbDe);
            Controls.Add(lblFecha);
            Controls.Add(lblResultado);
            Controls.Add(lblTasa);
            Controls.Add(lblMonto);
            Controls.Add(lblhacia);
            Controls.Add(lblDe);
            Controls.Add(label2);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label2;
        private Label lblDe;
        private Label lblhacia;
        private Label lblMonto;
        private Label lblTasa;
        private Label lblResultado;
        private Label lblFecha;
        private ComboBox cmbDe;
        private ComboBox cmbHacia;
        private TextBox txtMonto;
        private Button btnConvertir;
    }
}
