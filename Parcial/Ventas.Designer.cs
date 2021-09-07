
namespace Parcial
{
    partial class Ventas
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
            this.aliñado = new System.Windows.Forms.Label();
            this.especial = new System.Windows.Forms.Label();
            this.noaliñado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cedula = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnvender = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Resultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // aliñado
            // 
            this.aliñado.AutoSize = true;
            this.aliñado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aliñado.Location = new System.Drawing.Point(12, 45);
            this.aliñado.Name = "aliñado";
            this.aliñado.Size = new System.Drawing.Size(175, 17);
            this.aliñado.TabIndex = 0;
            this.aliñado.Text = "Panes Aliñados $1000:";
            this.aliñado.Click += new System.EventHandler(this.aliñado_Click);
            // 
            // especial
            // 
            this.especial.AutoSize = true;
            this.especial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especial.Location = new System.Drawing.Point(12, 128);
            this.especial.Name = "especial";
            this.especial.Size = new System.Drawing.Size(191, 17);
            this.especial.TabIndex = 1;
            this.especial.Text = "Panes Especiales $2000:";
            // 
            // noaliñado
            // 
            this.noaliñado.AutoSize = true;
            this.noaliñado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noaliñado.Location = new System.Drawing.Point(12, 89);
            this.noaliñado.Name = "noaliñado";
            this.noaliñado.Size = new System.Drawing.Size(189, 17);
            this.noaliñado.TabIndex = 2;
            this.noaliñado.Text = "Panes no Aliñados $500:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Ingrese Cant";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Ingrese Cant";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(209, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Ingrese Cant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Precio Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre del Cliente:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(622, 45);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(142, 22);
            this.name.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cédula del Cliente:";
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(622, 89);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(142, 22);
            this.cedula.TabIndex = 18;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(487, 176);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(265, 22);
            this.fecha.TabIndex = 19;
            this.fecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha y Hora de la Venta:";
            // 
            // btnvender
            // 
            this.btnvender.Location = new System.Drawing.Point(353, 254);
            this.btnvender.Name = "btnvender";
            this.btnvender.Size = new System.Drawing.Size(75, 23);
            this.btnvender.TabIndex = 21;
            this.btnvender.Text = "Vender";
            this.btnvender.UseVisualStyleBackColor = true;
            this.btnvender.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 22;
            this.textBox4.Text = "Total";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Resultados
            // 
            this.Resultados.FormattingEnabled = true;
            this.Resultados.ItemHeight = 16;
            this.Resultados.Location = new System.Drawing.Point(3, 311);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(425, 132);
            this.Resultados.TabIndex = 23;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultados);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnvender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.noaliñado);
            this.Controls.Add(this.especial);
            this.Controls.Add(this.aliñado);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aliñado;
        private System.Windows.Forms.Label especial;
        private System.Windows.Forms.Label noaliñado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cedula;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnvender;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox Resultados;
    }
}