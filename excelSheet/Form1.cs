using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace excelSheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Rename your custom Excel class to avoid conflicts
        class CustomExcel
        {
            string path = "";
            Excel.Application excelApp;
            Excel.Workbook wb;
            Excel.Worksheet ws;

            public CustomExcel(string path, int sheet)
            {
                this.path = path;
                excelApp = new Excel.Application();
                wb = excelApp.Workbooks.Open(path);
                ws = wb.Worksheets[sheet];
            }

            public string ReadCell(int i, int j)
            {
                i++;
                j++;
                if (ws.Cells[i, j].Value2 != null)
                {
                    return ws.Cells[i, j].Value2.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }

            public void Close()
            {
                wb.Close();
                Marshal.ReleaseComObject(ws);
                Marshal.ReleaseComObject(wb);
                excelApp.Quit();
                Marshal.ReleaseComObject(excelApp);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string filePath = @"E:\data.xlsx"; // Replace with your file path
            int sheetIndex = 1; // Replace with your sheet index (starting from 1)
            int cellRow = 1; // Replace with the row number of the cell to read
            int cellColumn = 1; // Replace with the column number of the cell to read
            
            CustomExcel customExcel = new CustomExcel(filePath, sheetIndex);
            string cellData = customExcel.ReadCell(cellRow, cellColumn);
            textBox1.Text = cellData;
            MessageBox.Show(cellData);
            customExcel.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Your code for handling text change in textBox1, if needed
        }
    }
}
