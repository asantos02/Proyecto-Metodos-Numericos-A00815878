namespace Proyecto_Metodos_Numericos_A00815878
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Secante = new System.Windows.Forms.Button();
            this.TrapezoidalCompuesta = new System.Windows.Forms.Button();
            this.TrapezoidalSimple = new System.Windows.Forms.Button();
            this.Simpson38 = new System.Windows.Forms.Button();
            this.Simpson13 = new System.Windows.Forms.Button();
            this.Biseccion = new System.Windows.Forms.Button();
            this.NewtonRaphson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 322);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Aceptar);
            this.tabPage1.Controls.Add(this.Secante);
            this.tabPage1.Controls.Add(this.TrapezoidalCompuesta);
            this.tabPage1.Controls.Add(this.TrapezoidalSimple);
            this.tabPage1.Controls.Add(this.Simpson38);
            this.tabPage1.Controls.Add(this.Simpson13);
            this.tabPage1.Controls.Add(this.Biseccion);
            this.tabPage1.Controls.Add(this.NewtonRaphson);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ecuaciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(236, 17);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 9;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            // 
            // Secante
            // 
            this.Secante.Location = new System.Drawing.Point(620, 253);
            this.Secante.Name = "Secante";
            this.Secante.Size = new System.Drawing.Size(75, 23);
            this.Secante.TabIndex = 8;
            this.Secante.Text = "Secante";
            this.Secante.UseVisualStyleBackColor = true;
            // 
            // TrapezoidalCompuesta
            // 
            this.TrapezoidalCompuesta.Location = new System.Drawing.Point(482, 253);
            this.TrapezoidalCompuesta.Name = "TrapezoidalCompuesta";
            this.TrapezoidalCompuesta.Size = new System.Drawing.Size(132, 23);
            this.TrapezoidalCompuesta.TabIndex = 7;
            this.TrapezoidalCompuesta.Text = "Trapezoidal Compuesta";
            this.TrapezoidalCompuesta.UseVisualStyleBackColor = true;
            // 
            // TrapezoidalSimple
            // 
            this.TrapezoidalSimple.Location = new System.Drawing.Point(354, 253);
            this.TrapezoidalSimple.Name = "TrapezoidalSimple";
            this.TrapezoidalSimple.Size = new System.Drawing.Size(122, 23);
            this.TrapezoidalSimple.TabIndex = 6;
            this.TrapezoidalSimple.Text = "Trapezoidal Simple";
            this.TrapezoidalSimple.UseVisualStyleBackColor = true;
            // 
            // Simpson38
            // 
            this.Simpson38.Location = new System.Drawing.Point(273, 253);
            this.Simpson38.Name = "Simpson38";
            this.Simpson38.Size = new System.Drawing.Size(75, 23);
            this.Simpson38.TabIndex = 5;
            this.Simpson38.Text = "Simpson 3/8 ";
            this.Simpson38.UseVisualStyleBackColor = true;
            // 
            // Simpson13
            // 
            this.Simpson13.Location = new System.Drawing.Point(192, 253);
            this.Simpson13.Name = "Simpson13";
            this.Simpson13.Size = new System.Drawing.Size(75, 23);
            this.Simpson13.TabIndex = 4;
            this.Simpson13.Text = "Simpson1/3";
            this.Simpson13.UseVisualStyleBackColor = true;
            // 
            // Biseccion
            // 
            this.Biseccion.Location = new System.Drawing.Point(111, 253);
            this.Biseccion.Name = "Biseccion";
            this.Biseccion.Size = new System.Drawing.Size(75, 23);
            this.Biseccion.TabIndex = 3;
            this.Biseccion.Text = "Biseccion";
            this.Biseccion.UseVisualStyleBackColor = true;
            // 
            // NewtonRaphson
            // 
            this.NewtonRaphson.Location = new System.Drawing.Point(3, 253);
            this.NewtonRaphson.Name = "NewtonRaphson";
            this.NewtonRaphson.Size = new System.Drawing.Size(102, 23);
            this.NewtonRaphson.TabIndex = 2;
            this.NewtonRaphson.Text = "Newton Raphson";
            this.NewtonRaphson.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de incognitas ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 325);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Secante;
        private System.Windows.Forms.Button TrapezoidalCompuesta;
        private System.Windows.Forms.Button TrapezoidalSimple;
        private System.Windows.Forms.Button Simpson38;
        private System.Windows.Forms.Button Simpson13;
        private System.Windows.Forms.Button Biseccion;
        private System.Windows.Forms.Button NewtonRaphson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

