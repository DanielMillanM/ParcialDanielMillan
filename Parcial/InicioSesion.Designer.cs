
namespace Parcial
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.ingresar = new System.Windows.Forms.Button();
            this.IngUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.usuario.Location = new System.Drawing.Point(155, 120);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(124, 22);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "Usuario\r\n";
            this.usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contraseña
            // 
            this.contraseña.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.contraseña.Location = new System.Drawing.Point(155, 198);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(124, 22);
            this.contraseña.TabIndex = 1;
            this.contraseña.Text = "Constraseña\r\n\r\n";
            this.contraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(176, 274);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(75, 23);
            this.ingresar.TabIndex = 2;
            this.ingresar.Text = "Ingresar";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // IngUser
            // 
            this.IngUser.AutoSize = true;
            this.IngUser.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IngUser.Location = new System.Drawing.Point(62, 85);
            this.IngUser.Name = "IngUser";
            this.IngUser.Size = new System.Drawing.Size(148, 20);
            this.IngUser.TabIndex = 3;
            this.IngUser.Text = "Ingrese su Usuario:";
            this.IngUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(62, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese su Contraseña:";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngUser);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Name = "InicioSesion";
            this.Text = "Inicio de Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.Label IngUser;
        private System.Windows.Forms.Label label1;
    }
}

