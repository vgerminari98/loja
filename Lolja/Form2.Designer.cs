namespace Lolja
{
    partial class Form2
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
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnPrdouto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(64, 54);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(95, 94);
            this.btnCategorias.TabIndex = 0;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(167, 54);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(95, 93);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnPrdouto
            // 
            this.btnPrdouto.Location = new System.Drawing.Point(270, 54);
            this.btnPrdouto.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrdouto.Name = "btnPrdouto";
            this.btnPrdouto.Size = new System.Drawing.Size(95, 94);
            this.btnPrdouto.TabIndex = 2;
            this.btnPrdouto.Text = "Produto";
            this.btnPrdouto.UseVisualStyleBackColor = true;
            this.btnPrdouto.Click += new System.EventHandler(this.btnPrdouto_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(433, 204);
            this.Controls.Add(this.btnPrdouto);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnCategorias);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Loja";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnPrdouto;
    }
}