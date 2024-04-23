using OfficeOpenXml;
using System.Data;

namespace Employee.Common.Utilities
{
    public class ExcelReader
    {
        protected ExcelReader()
        {
        }

        public static DataSet ReadFromExcel(bool hasHeader = true)
        {
            string path = $"D:\\AssesmentProjects\\Emp\\Employee data.xlsx";

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            DataSet excelDataset = new();
            using var excelPack = new ExcelPackage();

            // Load excel stream
            using (var stream = File.OpenRead(path))
            {
                excelPack.Load(stream);
            }

            foreach (var ws in excelPack.Workbook.Worksheets)
            {
                //Get all details as DataTable
                DataTable excelasTable = new DataTable();
                excelasTable.TableName = ws.Name;
                foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
                {
                    //Get colummn details
                    if (!string.IsNullOrEmpty(firstRowCell.Text))
                    {
                        string firstColumn = string.Format("Column {0}", firstRowCell.Start.Column);
                        excelasTable.Columns.Add(hasHeader ? firstRowCell.Text.Trim() : firstColumn);
                    }
                }
                var startRow = hasHeader ? 2 : 1;
                //Get row details
                for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
                {
                    var wsRow = ws.Cells[rowNum, 1, rowNum, excelasTable.Columns.Count];
                    DataRow row = excelasTable.Rows.Add();
                    foreach (var cell in wsRow)
                    {
                        row[cell.Start.Column - 1] = cell.Text;
                    }
                }
                excelDataset.Tables.Add(excelasTable);
            }

            return excelDataset;
        }
    }
}
