namespace viajes_sin_limites
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Escalas = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.paisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseVSLDataSet1 = new viajes_sin_limites.DatabaseVSLDataSet1();
            this.databaseVSLDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadesTableAdapter = new viajes_sin_limites.DatabaseVSLDataSet1TableAdapters.CiudadesTableAdapter();
            this.ciudadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.paisesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.paisesTableAdapter = new viajes_sin_limites.DatabaseVSLDataSet1TableAdapters.PaisesTableAdapter();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.paisesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.presupuesto = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.duracionV = new System.Windows.Forms.Label();
            this.CostoV = new System.Windows.Forms.Label();
            this.paisE = new System.Windows.Forms.Label();
            this.ciudadD = new System.Windows.Forms.Label();
            this.ciudadO = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVSLDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVSLDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Escalas
            // 
            this.Escalas.AutoSize = true;
            this.Escalas.Location = new System.Drawing.Point(11, 32);
            this.Escalas.Name = "Escalas";
            this.Escalas.Size = new System.Drawing.Size(63, 17);
            this.Escalas.TabIndex = 3;
            this.Escalas.Text = "Escalas";
            this.Escalas.UseVisualStyleBackColor = true;
            this.Escalas.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 20);
            this.textBox3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.paisesBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "Codigo";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // paisesBindingSource
            // 
            this.paisesBindingSource.DataMember = "Paises";
            this.paisesBindingSource.DataSource = this.databaseVSLDataSet1;
            // 
            // databaseVSLDataSet1
            // 
            this.databaseVSLDataSet1.DataSetName = "DatabaseVSLDataSet1";
            this.databaseVSLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseVSLDataSet1BindingSource
            // 
            this.databaseVSLDataSet1BindingSource.DataSource = this.databaseVSLDataSet1;
            this.databaseVSLDataSet1BindingSource.Position = 0;
            // 
            // ciudadesTableAdapter
            // 
            this.ciudadesTableAdapter.ClearBeforeFill = true;
            // 
            // ciudadesBindingSource1
            // 
            this.ciudadesBindingSource1.DataMember = "Ciudades";
            this.ciudadesBindingSource1.DataSource = this.databaseVSLDataSet1BindingSource;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 99);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 16;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.paisesBindingSource1;
            this.comboBox4.DisplayMember = "Nombre";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(6, 22);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 18;
            this.comboBox4.ValueMember = "Codigo";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // paisesBindingSource1
            // 
            this.paisesBindingSource1.DataMember = "Paises";
            this.paisesBindingSource1.DataSource = this.databaseVSLDataSet1;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(6, 57);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 19;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(6, 99);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 20;
            // 
            // paisesTableAdapter
            // 
            this.paisesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(109, 30);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(143, 21);
            this.comboBox7.TabIndex = 22;
            // 
            // paisesBindingSource2
            // 
            this.paisesBindingSource2.DataMember = "Paises";
            this.paisesBindingSource2.DataSource = this.databaseVSLDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "País";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Aeropuerto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 278);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda de Vuelos";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(148, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(73, 131);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.presupuesto);
            this.groupBox4.Controls.Add(this.comboBox7);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.Escalas);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(7, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 107);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Restricciones";
            // 
            // presupuesto
            // 
            this.presupuesto.AutoSize = true;
            this.presupuesto.Location = new System.Drawing.Point(11, 68);
            this.presupuesto.Name = "presupuesto";
            this.presupuesto.Size = new System.Drawing.Size(85, 17);
            this.presupuesto.TabIndex = 23;
            this.presupuesto.Text = "Presupuesto";
            this.presupuesto.UseVisualStyleBackColor = true;
            this.presupuesto.CheckedChanged += new System.EventHandler(this.presupuesto_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Controls.Add(this.comboBox5);
            this.groupBox3.Controls.Add(this.comboBox6);
            this.groupBox3.Location = new System.Drawing.Point(227, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 131);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destino";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 131);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Origen";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(390, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(281, 278);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resultados de la Búsqueda";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.duracionV);
            this.groupBox7.Controls.Add(this.CostoV);
            this.groupBox7.Controls.Add(this.paisE);
            this.groupBox7.Controls.Add(this.ciudadD);
            this.groupBox7.Controls.Add(this.ciudadO);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Location = new System.Drawing.Point(7, 20);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(268, 252);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Image = global::viajes_sin_limites.Properties.Resources.images;
            this.label10.Location = new System.Drawing.Point(7, 168);
            this.label10.MinimumSize = new System.Drawing.Size(250, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 75);
            this.label10.TabIndex = 10;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // duracionV
            // 
            this.duracionV.AutoSize = true;
            this.duracionV.Location = new System.Drawing.Point(122, 145);
            this.duracionV.MinimumSize = new System.Drawing.Size(135, 13);
            this.duracionV.Name = "duracionV";
            this.duracionV.Size = new System.Drawing.Size(135, 13);
            this.duracionV.TabIndex = 9;
            // 
            // CostoV
            // 
            this.CostoV.AutoSize = true;
            this.CostoV.Location = new System.Drawing.Point(122, 113);
            this.CostoV.MinimumSize = new System.Drawing.Size(135, 13);
            this.CostoV.Name = "CostoV";
            this.CostoV.Size = new System.Drawing.Size(135, 13);
            this.CostoV.TabIndex = 8;
            // 
            // paisE
            // 
            this.paisE.AutoSize = true;
            this.paisE.Location = new System.Drawing.Point(122, 80);
            this.paisE.MinimumSize = new System.Drawing.Size(135, 13);
            this.paisE.Name = "paisE";
            this.paisE.Size = new System.Drawing.Size(135, 13);
            this.paisE.TabIndex = 7;
            // 
            // ciudadD
            // 
            this.ciudadD.AutoSize = true;
            this.ciudadD.Location = new System.Drawing.Point(122, 50);
            this.ciudadD.MinimumSize = new System.Drawing.Size(135, 13);
            this.ciudadD.Name = "ciudadD";
            this.ciudadD.Size = new System.Drawing.Size(135, 13);
            this.ciudadD.TabIndex = 6;
            // 
            // ciudadO
            // 
            this.ciudadO.AutoSize = true;
            this.ciudadO.Location = new System.Drawing.Point(122, 19);
            this.ciudadO.MinimumSize = new System.Drawing.Size(135, 13);
            this.ciudadO.Name = "ciudadO";
            this.ciudadO.Size = new System.Drawing.Size(135, 13);
            this.ciudadO.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Duración del Viaje";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Costo del Viaje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Escala";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ciudad de Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ciudad de Origen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 298);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(693, 337);
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.Text = "Aventura sin Límite";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVSLDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVSLDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox Escalas;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DatabaseVSLDataSet1 databaseVSLDataSet1;
        private System.Windows.Forms.BindingSource databaseVSLDataSet1BindingSource;
        private DatabaseVSLDataSet1TableAdapters.CiudadesTableAdapter ciudadesTableAdapter;
        private System.Windows.Forms.BindingSource ciudadesBindingSource1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.BindingSource paisesBindingSource;
        private DatabaseVSLDataSet1TableAdapters.PaisesTableAdapter paisesTableAdapter;
        private System.Windows.Forms.BindingSource paisesBindingSource1;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.BindingSource paisesBindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label duracionV;
        private System.Windows.Forms.Label CostoV;
        private System.Windows.Forms.Label paisE;
        private System.Windows.Forms.Label ciudadD;
        private System.Windows.Forms.Label ciudadO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox presupuesto;
    }
}

