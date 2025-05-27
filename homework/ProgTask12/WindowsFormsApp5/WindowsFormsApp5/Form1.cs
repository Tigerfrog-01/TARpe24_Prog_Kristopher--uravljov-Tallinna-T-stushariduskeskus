using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        List<int> trueIndexes = new List<int>();
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("IsReturned?", typeof(bool));
            table.Columns.Add("Book title", typeof(string));
            table.Columns.Add("Lender", typeof(string));
            dataGridView1.DataSource = table;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\opilane\Downloads\file.txt");

            foreach (string line in lines)
            {
                string[] values = line.Split('/');
                object[] row = new object[values.Length];

                row[0] = values[0].Trim().ToLower() == "true";
                for (int j = 1; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                table.Rows.Add(row);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Data as Text File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                writer.Write((bool)row.Cells[0].Value ? "true" : "false");
                                for (int j = 1; j < dataGridView1.Columns.Count; j++)
                                {
                                    writer.Write("/");
                                    writer.Write(row.Cells[j].Value?.ToString());
                                }
                                writer.WriteLine();
                            }
                        }
                    }
                    MessageBox.Show("Data Exported!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }
        }
}
