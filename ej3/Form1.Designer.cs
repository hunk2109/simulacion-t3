namespace ej3
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcarn = new System.Windows.Forms.TextBox();
            this.txtnomb = new System.Windows.Forms.TextBox();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.btnrgis = new System.Windows.Forms.Button();
            this.btnelimi = new System.Windows.Forms.Button();
            this.btnsal = new System.Windows.Forms.Button();
            this.dgvempl = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsal);
            this.groupBox1.Controls.Add(this.btnelimi);
            this.groupBox1.Controls.Add(this.btnrgis);
            this.groupBox1.Controls.Add(this.dtpfecha);
            this.groupBox1.Controls.Add(this.txtsal);
            this.groupBox1.Controls.Add(this.txtnomb);
            this.groupBox1.Controls.Add(this.txtcarn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // txtcarn
            // 
            this.txtcarn.Location = new System.Drawing.Point(63, 35);
            this.txtcarn.Name = "txtcarn";
            this.txtcarn.Size = new System.Drawing.Size(100, 20);
            this.txtcarn.TabIndex = 4;
            this.txtcarn.Validated += new System.EventHandler(this.Txtcarn_Validated);
            // 
            // txtnomb
            // 
            this.txtnomb.Location = new System.Drawing.Point(63, 74);
            this.txtnomb.Name = "txtnomb";
            this.txtnomb.Size = new System.Drawing.Size(100, 20);
            this.txtnomb.TabIndex = 5;
            this.txtnomb.Validating += new System.ComponentModel.CancelEventHandler(this.Txtnomb_Validating);
            this.txtnomb.Validated += new System.EventHandler(this.Txtnomb_Validated);
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(63, 113);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(100, 20);
            this.txtsal.TabIndex = 6;
            this.txtsal.VisibleChanged += new System.EventHandler(this.Txtsal_VisibleChanged);
            this.txtsal.Validating += new System.ComponentModel.CancelEventHandler(this.Txtsal_Validating);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(63, 146);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 7;
            // 
            // btnrgis
            // 
            this.btnrgis.Location = new System.Drawing.Point(249, 33);
            this.btnrgis.Name = "btnrgis";
            this.btnrgis.Size = new System.Drawing.Size(75, 23);
            this.btnrgis.TabIndex = 8;
            this.btnrgis.Text = "Registrar";
            this.btnrgis.UseVisualStyleBackColor = true;
            this.btnrgis.Click += new System.EventHandler(this.Btnrgis_Click);
            // 
            // btnelimi
            // 
            this.btnelimi.Location = new System.Drawing.Point(249, 72);
            this.btnelimi.Name = "btnelimi";
            this.btnelimi.Size = new System.Drawing.Size(75, 23);
            this.btnelimi.TabIndex = 9;
            this.btnelimi.Text = "Eliminar";
            this.btnelimi.UseVisualStyleBackColor = true;
            this.btnelimi.Click += new System.EventHandler(this.Btnelimi_Click);
            // 
            // btnsal
            // 
            this.btnsal.Location = new System.Drawing.Point(249, 111);
            this.btnsal.Name = "btnsal";
            this.btnsal.Size = new System.Drawing.Size(75, 23);
            this.btnsal.TabIndex = 10;
            this.btnsal.Text = "Salir";
            this.btnsal.UseVisualStyleBackColor = true;
            this.btnsal.Click += new System.EventHandler(this.Btnsal_Click);
            // 
            // dgvempl
            // 
            this.dgvempl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempl.Location = new System.Drawing.Point(12, 259);
            this.dgvempl.Name = "dgvempl";
            this.dgvempl.Size = new System.Drawing.Size(330, 179);
            this.dgvempl.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.dgvempl);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsal;
        private System.Windows.Forms.Button btnelimi;
        private System.Windows.Forms.Button btnrgis;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.TextBox txtnomb;
        private System.Windows.Forms.TextBox txtcarn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvempl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

