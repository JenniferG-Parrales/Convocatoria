
namespace ProductManager
{
    partial class MenuFrm
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
            this.btnBuscarProductos = new System.Windows.Forms.Button();
            this.btnRegistrarProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.Location = new System.Drawing.Point(76, 89);
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.Size = new System.Drawing.Size(75, 36);
            this.btnBuscarProductos.TabIndex = 0;
            this.btnBuscarProductos.Text = "Buscar Productos";
            this.btnBuscarProductos.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarProductos
            // 
            this.btnRegistrarProductos.Location = new System.Drawing.Point(214, 89);
            this.btnRegistrarProductos.Name = "btnRegistrarProductos";
            this.btnRegistrarProductos.Size = new System.Drawing.Size(75, 38);
            this.btnRegistrarProductos.TabIndex = 1;
            this.btnRegistrarProductos.Text = "Registrar Productos";
            this.btnRegistrarProductos.UseVisualStyleBackColor = true;
            // 
            // MenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 227);
            this.Controls.Add(this.btnRegistrarProductos);
            this.Controls.Add(this.btnBuscarProductos);
            this.Name = "MenuFrm";
            this.Text = "MenuFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarProductos;
        private System.Windows.Forms.Button btnRegistrarProductos;
    }
}