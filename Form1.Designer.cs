namespace Segundo_Parcial
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
            this.grilla_alumnos = new System.Windows.Forms.DataGridView();
            this.grilla_mat_en_curso = new System.Windows.Forms.DataGridView();
            this.grilla_materias_desaprobadas = new System.Windows.Forms.DataGridView();
            this.grilla_materias_aprobadas = new System.Windows.Forms.DataGridView();
            this.alta_alumno_btn = new System.Windows.Forms.Button();
            this.ordena_apellido_az = new System.Windows.Forms.Button();
            this.baja_alumno_btn = new System.Windows.Forms.Button();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.apellidotxt = new System.Windows.Forms.TextBox();
            this.legajotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_tipo_materia = new System.Windows.Forms.ComboBox();
            this.codigotxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.denominaciontxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.prom_mat_aprobadastxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.alta_materia_btn = new System.Windows.Forms.Button();
            this.ordena_apellido_za = new System.Windows.Forms.Button();
            this.prom_mat_generaltxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.agregar_nota_btn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.notatxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_alumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_mat_en_curso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_materias_desaprobadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_materias_aprobadas)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla_alumnos
            // 
            this.grilla_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_alumnos.Location = new System.Drawing.Point(76, 36);
            this.grilla_alumnos.MultiSelect = false;
            this.grilla_alumnos.Name = "grilla_alumnos";
            this.grilla_alumnos.ReadOnly = true;
            this.grilla_alumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_alumnos.Size = new System.Drawing.Size(254, 150);
            this.grilla_alumnos.TabIndex = 0;
            this.grilla_alumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_alumnos_CellClick);
            // 
            // grilla_mat_en_curso
            // 
            this.grilla_mat_en_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_mat_en_curso.Location = new System.Drawing.Point(563, 33);
            this.grilla_mat_en_curso.MultiSelect = false;
            this.grilla_mat_en_curso.Name = "grilla_mat_en_curso";
            this.grilla_mat_en_curso.ReadOnly = true;
            this.grilla_mat_en_curso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_mat_en_curso.Size = new System.Drawing.Size(256, 150);
            this.grilla_mat_en_curso.TabIndex = 1;
            // 
            // grilla_materias_desaprobadas
            // 
            this.grilla_materias_desaprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_materias_desaprobadas.Location = new System.Drawing.Point(579, 315);
            this.grilla_materias_desaprobadas.MultiSelect = false;
            this.grilla_materias_desaprobadas.Name = "grilla_materias_desaprobadas";
            this.grilla_materias_desaprobadas.ReadOnly = true;
            this.grilla_materias_desaprobadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_materias_desaprobadas.Size = new System.Drawing.Size(240, 130);
            this.grilla_materias_desaprobadas.TabIndex = 2;
            // 
            // grilla_materias_aprobadas
            // 
            this.grilla_materias_aprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_materias_aprobadas.Location = new System.Drawing.Point(76, 315);
            this.grilla_materias_aprobadas.MultiSelect = false;
            this.grilla_materias_aprobadas.Name = "grilla_materias_aprobadas";
            this.grilla_materias_aprobadas.ReadOnly = true;
            this.grilla_materias_aprobadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_materias_aprobadas.Size = new System.Drawing.Size(254, 130);
            this.grilla_materias_aprobadas.TabIndex = 3;
            // 
            // alta_alumno_btn
            // 
            this.alta_alumno_btn.Location = new System.Drawing.Point(26, 242);
            this.alta_alumno_btn.Name = "alta_alumno_btn";
            this.alta_alumno_btn.Size = new System.Drawing.Size(75, 23);
            this.alta_alumno_btn.TabIndex = 4;
            this.alta_alumno_btn.Text = "Alta";
            this.alta_alumno_btn.UseVisualStyleBackColor = true;
            this.alta_alumno_btn.Click += new System.EventHandler(this.alta_alumno_btn_Click);
            // 
            // ordena_apellido_az
            // 
            this.ordena_apellido_az.Location = new System.Drawing.Point(199, 242);
            this.ordena_apellido_az.Name = "ordena_apellido_az";
            this.ordena_apellido_az.Size = new System.Drawing.Size(115, 34);
            this.ordena_apellido_az.TabIndex = 5;
            this.ordena_apellido_az.Text = "Ordenar por Apellido (A-Z)";
            this.ordena_apellido_az.UseVisualStyleBackColor = true;
            this.ordena_apellido_az.Click += new System.EventHandler(this.ordena_apellido_az_Click);
            // 
            // baja_alumno_btn
            // 
            this.baja_alumno_btn.Location = new System.Drawing.Point(107, 242);
            this.baja_alumno_btn.Name = "baja_alumno_btn";
            this.baja_alumno_btn.Size = new System.Drawing.Size(75, 23);
            this.baja_alumno_btn.TabIndex = 6;
            this.baja_alumno_btn.Text = "Baja";
            this.baja_alumno_btn.UseVisualStyleBackColor = true;
            this.baja_alumno_btn.Click += new System.EventHandler(this.baja_alumno_btn_Click);
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(165, 206);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(75, 20);
            this.nombretxt.TabIndex = 7;
            // 
            // apellidotxt
            // 
            this.apellidotxt.Location = new System.Drawing.Point(255, 205);
            this.apellidotxt.Name = "apellidotxt";
            this.apellidotxt.Size = new System.Drawing.Size(75, 20);
            this.apellidotxt.TabIndex = 8;
            // 
            // legajotxt
            // 
            this.legajotxt.Location = new System.Drawing.Point(80, 205);
            this.legajotxt.Name = "legajotxt";
            this.legajotxt.Size = new System.Drawing.Size(75, 20);
            this.legajotxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Legajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lista de alumnos";
            // 
            // combo_tipo_materia
            // 
            this.combo_tipo_materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo_materia.FormattingEnabled = true;
            this.combo_tipo_materia.Items.AddRange(new object[] {
            "Basica",
            "Especializada"});
            this.combo_tipo_materia.Location = new System.Drawing.Point(742, 205);
            this.combo_tipo_materia.Name = "combo_tipo_materia";
            this.combo_tipo_materia.Size = new System.Drawing.Size(87, 21);
            this.combo_tipo_materia.TabIndex = 14;
            // 
            // codigotxt
            // 
            this.codigotxt.Location = new System.Drawing.Point(563, 206);
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.Size = new System.Drawing.Size(72, 20);
            this.codigotxt.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Codigo";
            // 
            // denominaciontxt
            // 
            this.denominaciontxt.Location = new System.Drawing.Point(651, 205);
            this.denominaciontxt.Name = "denominaciontxt";
            this.denominaciontxt.Size = new System.Drawing.Size(75, 20);
            this.denominaciontxt.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Denominacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(633, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Materias en curso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(129, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Materias Aprobadas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(633, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Materias Desaprobadas";
            // 
            // prom_mat_aprobadastxt
            // 
            this.prom_mat_aprobadastxt.Location = new System.Drawing.Point(414, 405);
            this.prom_mat_aprobadastxt.Name = "prom_mat_aprobadastxt";
            this.prom_mat_aprobadastxt.ReadOnly = true;
            this.prom_mat_aprobadastxt.Size = new System.Drawing.Size(75, 20);
            this.prom_mat_aprobadastxt.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(373, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Promedio materias aprobadas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(749, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tipo de materia";
            // 
            // alta_materia_btn
            // 
            this.alta_materia_btn.Location = new System.Drawing.Point(622, 232);
            this.alta_materia_btn.Name = "alta_materia_btn";
            this.alta_materia_btn.Size = new System.Drawing.Size(136, 23);
            this.alta_materia_btn.TabIndex = 27;
            this.alta_materia_btn.Text = "Alta de materia ";
            this.alta_materia_btn.UseVisualStyleBackColor = true;
            this.alta_materia_btn.Click += new System.EventHandler(this.alta_materia_btn_Click);
            // 
            // ordena_apellido_za
            // 
            this.ordena_apellido_za.Location = new System.Drawing.Point(320, 242);
            this.ordena_apellido_za.Name = "ordena_apellido_za";
            this.ordena_apellido_za.Size = new System.Drawing.Size(115, 34);
            this.ordena_apellido_za.TabIndex = 31;
            this.ordena_apellido_za.Text = "Ordenar por Apellido(Z-A)";
            this.ordena_apellido_za.UseVisualStyleBackColor = true;
            this.ordena_apellido_za.Click += new System.EventHandler(this.ordena_apellido_za_Click);
            // 
            // prom_mat_generaltxt
            // 
            this.prom_mat_generaltxt.Location = new System.Drawing.Point(414, 354);
            this.prom_mat_generaltxt.Name = "prom_mat_generaltxt";
            this.prom_mat_generaltxt.ReadOnly = true;
            this.prom_mat_generaltxt.Size = new System.Drawing.Size(75, 20);
            this.prom_mat_generaltxt.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(373, 315);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 15);
            this.label15.TabIndex = 35;
            this.label15.Text = "Promedio materias general";
            // 
            // agregar_nota_btn
            // 
            this.agregar_nota_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_nota_btn.Location = new System.Drawing.Point(395, 61);
            this.agregar_nota_btn.Name = "agregar_nota_btn";
            this.agregar_nota_btn.Size = new System.Drawing.Size(116, 44);
            this.agregar_nota_btn.TabIndex = 36;
            this.agregar_nota_btn.Text = "Agregar nota a materia en curso";
            this.agregar_nota_btn.UseVisualStyleBackColor = true;
            this.agregar_nota_btn.Click += new System.EventHandler(this.agregar_nota_btn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(437, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 15);
            this.label12.TabIndex = 38;
            this.label12.Text = "Nota";
            // 
            // notatxt
            // 
            this.notatxt.Location = new System.Drawing.Point(414, 149);
            this.notatxt.Name = "notatxt";
            this.notatxt.Size = new System.Drawing.Size(75, 20);
            this.notatxt.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 457);
            this.Controls.Add(this.notatxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.agregar_nota_btn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.prom_mat_generaltxt);
            this.Controls.Add(this.ordena_apellido_za);
            this.Controls.Add(this.alta_materia_btn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.prom_mat_aprobadastxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.denominaciontxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.codigotxt);
            this.Controls.Add(this.combo_tipo_materia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.legajotxt);
            this.Controls.Add(this.apellidotxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.baja_alumno_btn);
            this.Controls.Add(this.ordena_apellido_az);
            this.Controls.Add(this.alta_alumno_btn);
            this.Controls.Add(this.grilla_materias_aprobadas);
            this.Controls.Add(this.grilla_materias_desaprobadas);
            this.Controls.Add(this.grilla_mat_en_curso);
            this.Controls.Add(this.grilla_alumnos);
            this.Name = "Form1";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_alumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_mat_en_curso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_materias_desaprobadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_materias_aprobadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_alumnos;
        private System.Windows.Forms.DataGridView grilla_mat_en_curso;
        private System.Windows.Forms.DataGridView grilla_materias_desaprobadas;
        private System.Windows.Forms.DataGridView grilla_materias_aprobadas;
        private System.Windows.Forms.Button alta_alumno_btn;
        private System.Windows.Forms.Button ordena_apellido_az;
        private System.Windows.Forms.Button baja_alumno_btn;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox apellidotxt;
        private System.Windows.Forms.TextBox legajotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_tipo_materia;
        private System.Windows.Forms.TextBox codigotxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox denominaciontxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox prom_mat_aprobadastxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button alta_materia_btn;
        private System.Windows.Forms.Button ordena_apellido_za;
        private System.Windows.Forms.TextBox prom_mat_generaltxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button agregar_nota_btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox notatxt;
    }
}

