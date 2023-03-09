namespace postdgress
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
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.btn_Desconectar = new System.Windows.Forms.Button();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.dgv_Consulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Consulta = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Pais = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Eliminar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Actualizar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Conectar.Location = new System.Drawing.Point(25, 42);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(138, 44);
            this.btn_Conectar.TabIndex = 0;
            this.btn_Conectar.Text = "CONECTARSE";
            this.btn_Conectar.UseVisualStyleBackColor = false;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // btn_Desconectar
            // 
            this.btn_Desconectar.BackColor = System.Drawing.Color.Yellow;
            this.btn_Desconectar.Location = new System.Drawing.Point(25, 118);
            this.btn_Desconectar.Name = "btn_Desconectar";
            this.btn_Desconectar.Size = new System.Drawing.Size(138, 44);
            this.btn_Desconectar.TabIndex = 1;
            this.btn_Desconectar.Text = "DESCONECTARSE";
            this.btn_Desconectar.UseVisualStyleBackColor = false;
            this.btn_Desconectar.Click += new System.EventHandler(this.btn_Desconectar_Click);
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.BackColor = System.Drawing.Color.Red;
            this.btn_Consulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Consulta.Location = new System.Drawing.Point(20, 400);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(151, 42);
            this.btn_Consulta.TabIndex = 2;
            this.btn_Consulta.Text = "CONSULTA";
            this.btn_Consulta.UseVisualStyleBackColor = false;
            this.btn_Consulta.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // dgv_Consulta
            // 
            this.dgv_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Consulta.Location = new System.Drawing.Point(200, 59);
            this.dgv_Consulta.Name = "dgv_Consulta";
            this.dgv_Consulta.Size = new System.Drawing.Size(480, 189);
            this.dgv_Consulta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE A BUSCAR";
            // 
            // txt_Consulta
            // 
            this.txt_Consulta.Location = new System.Drawing.Point(15, 342);
            this.txt_Consulta.Name = "txt_Consulta";
            this.txt_Consulta.Size = new System.Drawing.Size(156, 20);
            this.txt_Consulta.TabIndex = 5;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(764, 200);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Id.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(764, 281);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 7;
            // 
            // txt_Pais
            // 
            this.txt_Pais.Location = new System.Drawing.Point(764, 353);
            this.txt_Pais.Name = "txt_Pais";
            this.txt_Pais.Size = new System.Drawing.Size(100, 20);
            this.txt_Pais.TabIndex = 8;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(764, 412);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(100, 20);
            this.txt_Edad.TabIndex = 9;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(801, 177);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(23, 20);
            this.lbl_Id.TabIndex = 10;
            this.lbl_Id.Text = "Id";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(782, 246);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(65, 20);
            this.lbl_Nombre.TabIndex = 11;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(791, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(791, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Edad";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.Red;
            this.btn_Agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Agregar.Location = new System.Drawing.Point(751, 474);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(136, 42);
            this.btn_Agregar.TabIndex = 14;
            this.btn_Agregar.Text = "AGREGAR";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Mostrar.Location = new System.Drawing.Point(28, 188);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(135, 43);
            this.btn_Mostrar.TabIndex = 15;
            this.btn_Mostrar.Text = "MOSTRAR REGISTROS";
            this.btn_Mostrar.UseVisualStyleBackColor = false;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Cerrar.Location = new System.Drawing.Point(777, 34);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(110, 61);
            this.btn_Cerrar.TabIndex = 16;
            this.btn_Cerrar.Text = "CERRAR APLICACION";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(527, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "ELIMINAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(506, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "NOMBRE A ELIMINAR";
            // 
            // txt_Eliminar
            // 
            this.txt_Eliminar.Location = new System.Drawing.Point(527, 342);
            this.txt_Eliminar.Name = "txt_Eliminar";
            this.txt_Eliminar.Size = new System.Drawing.Size(153, 20);
            this.txt_Eliminar.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(262, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 40);
            this.button2.TabIndex = 20;
            this.button2.Text = "ACTUALIZAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(233, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "NOMBRE A ACTUALIZAR";
            // 
            // txt_Actualizar
            // 
            this.txt_Actualizar.Location = new System.Drawing.Point(262, 342);
            this.txt_Actualizar.Name = "txt_Actualizar";
            this.txt_Actualizar.Size = new System.Drawing.Size(159, 20);
            this.txt_Actualizar.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(298, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "CRUD en PostgreSQL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 577);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Actualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_Eliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.txt_Pais);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.txt_Consulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Consulta);
            this.Controls.Add(this.btn_Consulta);
            this.Controls.Add(this.btn_Desconectar);
            this.Controls.Add(this.btn_Conectar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.Button btn_Desconectar;
        private System.Windows.Forms.Button btn_Consulta;
        private System.Windows.Forms.DataGridView dgv_Consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Consulta;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Pais;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Eliminar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Actualizar;
        private System.Windows.Forms.Label label6;
    }
}

