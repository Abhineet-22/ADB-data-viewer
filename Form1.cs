using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace AdbDataViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCpuInfo(@"C:\Users\hp\cpuinfo.txt", dataGridView1);
            LoadKeyValueRows(@"C:\Users\hp\contactinfo.txt", dataGridView2);
            LoadKeyValueRows(@"C:\Users\hp\smsinfo.txt", dataGridView3);
        }

        private void LoadCpuInfo(string path, DataGridView grid)
        {
            var table = new DataTable();
            table.Columns.Add("Key");
            table.Columns.Add("Value");

            foreach (var line in File.ReadAllLines(path))
            {
                var parts = line.Split(':');
                if (parts.Length >= 2)
                {
                    string key = parts[0].Trim();
                    string value = string.Join(":", parts, 1, parts.Length - 1).Trim();
                    table.Rows.Add(key, value);
                }
            }

            grid.DataSource = table;
        }

        private void LoadKeyValueRows(string path, DataGridView grid)
        {
            var table = new DataTable();
            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                var matches = Regex.Matches(line, @"(\w+)=([^,]+)");
                var dict = new Dictionary<string, string>();

                foreach (Match match in matches)
                {
                    var key = match.Groups[1].Value;
                    var value = match.Groups[2].Value;
                    if (!table.Columns.Contains(key))
                        table.Columns.Add(key);
                    dict[key] = value;
                }

                var row = table.NewRow();
                foreach (var kvp in dict)
                    row[kvp.Key] = kvp.Value;

                table.Rows.Add(row);
            }

            grid.DataSource = table;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Create a new document
            Document document = new Document(PageSize.A4);
            string pdfFilePath = @"C:\Users\hp\GeneratedReport.pdf";

            // Create a PDF writer instance to write the document to a file
            PdfWriter.GetInstance(document, new FileStream(pdfFilePath, FileMode.Create));

            // Open the document for writing
            document.Open();

            // Add a title to the PDF
            document.Add(new Paragraph("Report Generated from Extracted Data"));
            document.Add(new Paragraph("\n\n"));

            // Fetch data from the DataGridView
            DataTable dataTable = (DataTable)dataGridView1.DataSource;

            // Create a table to display the data in the PDF
            PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);

            // Add column headers to the table
            foreach (DataColumn column in dataTable.Columns)
            {
                pdfTable.AddCell(column.ColumnName);
            }

            // Add rows to the table
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var cell in row.ItemArray)
                {
                    pdfTable.AddCell(cell.ToString());
                }
            }

            // Add the table to the document
            document.Add(pdfTable);

            // Close the document
            document.Close();

            // Show a success message
            MessageBox.Show("PDF Report Generated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

