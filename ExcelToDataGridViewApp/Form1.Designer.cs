namespace ExcelToDataGridViewApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable de diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se están usando.
        /// </summary>
        /// <param name="disposing">True si los recursos administrados deben ser eliminados; en caso contrario, false.</param>
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
        /// Método requerido para la variable de diseñador.
        /// No lo modifique con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPasteFromExcel = new System.Windows.Forms.Button();
            this.buttonRunPythonScript = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(776, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonPasteFromExcel
            // 
            this.buttonPasteFromExcel.Location = new System.Drawing.Point(12, 400);
            this.buttonPasteFromExcel.Name = "buttonPasteFromExcel";
            this.buttonPasteFromExcel.Size = new System.Drawing.Size(200, 40);
            this.buttonPasteFromExcel.TabIndex = 1;
            this.buttonPasteFromExcel.Text = "Pegar desde Excel";
            this.buttonPasteFromExcel.UseVisualStyleBackColor = true;
            this.buttonPasteFromExcel.Click += new System.EventHandler(this.buttonPasteFromExcel_Click);
            // 
            // buttonRunPythonScript
            // 
            this.buttonRunPythonScript.Location = new System.Drawing.Point(284, 400);
            this.buttonRunPythonScript.Name = "buttonRunPythonScript";
            this.buttonRunPythonScript.Size = new System.Drawing.Size(186, 40);
            this.buttonRunPythonScript.TabIndex = 2;
            this.buttonRunPythonScript.Text = "Act. Tarea";
            this.buttonRunPythonScript.UseVisualStyleBackColor = true;
            this.buttonRunPythonScript.Click += new System.EventHandler(this.buttonRunPythonScript_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRunPythonScript);
            this.Controls.Add(this.buttonPasteFromExcel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Pegar datos desde Excel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPasteFromExcel;
        private System.Windows.Forms.Button buttonRunPythonScript;
    }
}
