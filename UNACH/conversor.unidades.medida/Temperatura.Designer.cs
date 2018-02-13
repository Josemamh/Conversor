namespace conversor.unidades.medida
{
    partial class Temperatura
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
            this.opcion2 = new System.Windows.Forms.ComboBox();
            this.opcion1 = new System.Windows.Forms.ComboBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // opcion2
            // 
            this.opcion2.FormattingEnabled = true;
            this.opcion2.Items.AddRange(new object[] {
            "kilometros",
            "hectometros",
            "decametros",
            "metros",
            "decimetros",
            "centimetros",
            "milimetros"});
            this.opcion2.Location = new System.Drawing.Point(249, 74);
            this.opcion2.Name = "opcion2";
            this.opcion2.Size = new System.Drawing.Size(121, 21);
            this.opcion2.TabIndex = 28;
            // 
            // opcion1
            // 
            this.opcion1.FormattingEnabled = true;
            this.opcion1.Items.AddRange(new object[] {
            "kilometros",
            "hectometros",
            "decametros",
            "metros",
            "decimetros",
            "centimetros",
            "milimetros"});
            this.opcion1.Location = new System.Drawing.Point(68, 74);
            this.opcion1.Name = "opcion1";
            this.opcion1.Size = new System.Drawing.Size(121, 21);
            this.opcion1.TabIndex = 27;
            // 
            // Resultado
            // 
            this.Resultado.Font = new System.Drawing.Font("MS Office Symbol Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(304, 188);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(64, 26);
            this.Resultado.TabIndex = 26;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("MS Office Symbol Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(221, 188);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(77, 19);
            this.lblResultado.TabIndex = 25;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("MS Office Symbol Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(68, 181);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 32);
            this.btnConvertir.TabIndex = 24;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("MS Office Symbol Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(221, 69);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(22, 19);
            this.lblA.TabIndex = 23;
            this.lblA.Text = "A:";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("MS Office Symbol Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(31, 69);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(31, 19);
            this.lblDe.TabIndex = 22;
            this.lblDe.Text = "De:";
            // 
            // Cantidad
            // 
            this.Cantidad.Font = new System.Drawing.Font("MS Office Symbol Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.Location = new System.Drawing.Point(198, 17);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(64, 26);
            this.Cantidad.TabIndex = 21;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("MS Office Symbol Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(50, 14);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(142, 19);
            this.lblCantidad.TabIndex = 20;
            this.lblCantidad.Text = "Cantidad a convertir:";
            // 
            // Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 229);
            this.Controls.Add(this.opcion2);
            this.Controls.Add(this.opcion1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.lblCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Temperatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox opcion2;
        private System.Windows.Forms.ComboBox opcion1;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Label lblCantidad;
    }
}