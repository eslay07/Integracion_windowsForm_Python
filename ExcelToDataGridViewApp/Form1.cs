using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToDataGridViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento para el botón "Pegar desde Excel"
        private void buttonPasteFromExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el contenido del portapapeles
                string clipboardData = Clipboard.GetText();

                // Verificar si hay datos en el portapapeles
                if (!string.IsNullOrEmpty(clipboardData))
                {
                    // Dividir los datos por líneas y luego por tabuladores
                    string[] rows = clipboardData.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    // Establecer las columnas del DataGridView según el número de columnas del primer renglón
                    dataGridView1.ColumnCount = rows[0].Split('\t').Length;

                    // Limpiar las filas del DataGridView
                    dataGridView1.Rows.Clear();

                    // Agregar los datos al DataGridView
                    foreach (var row in rows)
                    {
                        string[] cells = row.Split('\t');
                        dataGridView1.Rows.Add(cells);
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos en el portapapeles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al pegar los datos: " + ex.Message);
            }
        }

        // Evento para el botón "Ejecutar Script Python"
        private void buttonRunPythonScript_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta completa al script de Python
                string pythonScriptPath = @"E:\Proyecto_compras\AUTOMATIZACION_TELCOS\busqueda_segundo_plano.py";

                // Ruta al ejecutable de Python (asegurarte de que Python esté instalado)
                string pythonExePath = @"C:\Users\jimmy\AppData\Local\Programs\Python\Python312\python.exe";

                // Crear el proceso para ejecutar el script de Python
                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    FileName = pythonExePath,
                    Arguments = pythonScriptPath,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                MessageBox.Show("La Automatizacion comenzo a Ejecutarse ! :) ");

                // Iniciar el proceso
                Process process = Process.Start(startInfo);
                process.WaitForExit();
                MessageBox.Show("Script ejecutado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el script: " + ex.Message);
            }
        }
    }
}
       