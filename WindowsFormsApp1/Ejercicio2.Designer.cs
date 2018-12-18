namespace WindowsFormsApp1
{
    partial class Ejercicio2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.habitantes1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd1DataSet = new WindowsFormsApp1.bd1DataSet();
            this.habitantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.habitantesTableAdapter = new WindowsFormsApp1.bd1DataSetTableAdapters.habitantesTableAdapter();
            this.habitantes1TableAdapter = new WindowsFormsApp1.bd1DataSetTableAdapters.habitantes1TableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.habitantes1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitantesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ejercicio2";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.habitantes1BindingSource;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(333, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "dni";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // habitantes1BindingSource
            // 
            this.habitantes1BindingSource.DataMember = "habitantes1";
            this.habitantes1BindingSource.DataSource = this.bd1DataSet;
            // 
            // bd1DataSet
            // 
            this.bd1DataSet.DataSetName = "bd1DataSet";
            this.bd1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // habitantesBindingSource
            // 
            this.habitantesBindingSource.DataMember = "habitantes";
            this.habitantesBindingSource.DataSource = this.bd1DataSet;
            // 
            // habitantesTableAdapter
            // 
            this.habitantesTableAdapter.ClearBeforeFill = true;
            // 
            // habitantes1TableAdapter
            // 
            this.habitantes1TableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.habitantes1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitantesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private bd1DataSet bd1DataSet;
        private System.Windows.Forms.BindingSource habitantesBindingSource;
        private bd1DataSetTableAdapters.habitantesTableAdapter habitantesTableAdapter;
        private System.Windows.Forms.BindingSource habitantes1BindingSource;
        private bd1DataSetTableAdapters.habitantes1TableAdapter habitantes1TableAdapter;
        private System.Windows.Forms.TextBox textBox1;
    }
}