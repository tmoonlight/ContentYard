using System;
using System.Data;
using System.IO;
using System.Web;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

public static class ExportHelper
{
    /// <summary>
    /// 导出Excel文件
    /// </summary>
    /// <param name="fileName"></param>
    /// <param name="dataSet">DataSet中每个DataTable生成一个Sheet</param>
    public static void ExportExcel(string fileName, DataSet dataSet)
    {
        if (dataSet.Tables.Count == 0)
        {
            return;
        }

        using (MemoryStream stream = DataTable2ExcelStream(dataSet))
        {
            FileStream fs = new FileStream(fileName, FileMode.CreateNew);
            stream.WriteTo(fs);
            fs.Flush();
            fs.Close();
        }
    }

    public static void ExportExcel(string fileName, DataTable dataTable)
    {
        DataSet dataSet = new DataSet();
        dataSet.Tables.Add(dataTable);
        ExportExcel(fileName, dataSet);
    }

    /// <summary>
    /// Web导出Excel文件
    /// </summary>
    /// <param name="fileName"></param>
    /// <param name="dataSet">DataSet中每个DataTable生成一个Sheet</param>
    public static void ResponseExcel(string fileName, DataSet dataSet)
    {
        if (dataSet.Tables.Count == 0)
        {
            return;
        }

        using (MemoryStream stream = DataTable2ExcelStream(dataSet))
        {
            ExportExcel(fileName, stream);
        }
    }

    public static void ResponseExcel(string fileName, DataTable dataTable)
    {
        DataSet dataSet = new DataSet();
        dataSet.Tables.Add(dataTable.Copy());
        ResponseExcel(fileName, dataSet);
    }

    private static void ExportExcel(string fileName, MemoryStream stream)
    {
        //HttpContext.Current.Response.Clear();
        //HttpContext.Current.Response.Charset = "UTF-8";
        //HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment;filename= " + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8));
        //HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF8;
        //HttpContext.Current.Response.ContentType = "application/ms-excel";
        //HttpContext.Current.Response.BinaryWrite(stream.ToArray());
        //HttpContext.Current.Response.Flush();
        //HttpContext.Current.Response.End();        
    }

    private static MemoryStream DataTable2ExcelStream(DataSet dataSet)
    {
        MemoryStream stream = new MemoryStream();
        SpreadsheetDocument document = SpreadsheetDocument.Create(stream,
            SpreadsheetDocumentType.Workbook);

        WorkbookPart workbookPart = document.AddWorkbookPart();
        workbookPart.Workbook = new Workbook();

        Sheets sheets = document.WorkbookPart.Workbook.AppendChild(new Sheets());

        for (int i = 0; i < dataSet.Tables.Count; i++)
        {
            DataTable dataTable = dataSet.Tables[i];
            WorksheetPart worksheetPart = document.WorkbookPart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            Sheet sheet = new Sheet
            {
                Id = document.WorkbookPart.GetIdOfPart(worksheetPart),
                SheetId = (UInt32)(i + 1),
                Name = dataTable.TableName
            };
            sheets.Append(sheet);

            SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

            Row headerRow = CreateHeaderRow(dataTable.Columns);
            sheetData.Append(headerRow);

            for (int j = 0; j < dataTable.Rows.Count; j++)
            {
                sheetData.Append(CreateRow(dataTable.Rows[j], j + 2));
            }
        }

        document.Close();

        return stream;
    }

    private static Row CreateHeaderRow(DataColumnCollection columns)
    {
        Row header = new Row();
        for (int i = 0; i < columns.Count; i++)
        {
            Cell cell = CreateCell(i + 1, 1, columns[i].ColumnName, CellValues.String);
            header.Append(cell);
        }
        return header;
    }

    private static Row CreateRow(DataRow dataRow, int rowIndex)
    {
        Row row = new Row();
        for (int i = 0; i < dataRow.Table.Columns.Count; i++)
        {
            Cell cell = CreateCell(i + 1, rowIndex, dataRow[i], GetType(dataRow.Table.Columns[i].DataType));
            row.Append(cell);
        }
        return row;
    }

    private static CellValues GetType(Type type)
    {
        if (type == typeof(decimal))
        {
            return CellValues.Number;
        }
        //if ((type == typeof(DateTime)))
        //{
        //    return CellValues.Date;
        //}
        return CellValues.SharedString;
    }

    private static Cell CreateCell(int columnIndex, int rowIndex, object cellValue, CellValues cellValues)
    {
        Cell cell = new Cell
        {
            CellReference = GetCellReference(columnIndex) + rowIndex,
            CellValue = new CellValue { Text = cellValue.ToString() },
            DataType = new EnumValue<CellValues>(cellValues),
            StyleIndex = 0
        };
        return cell;
    }

    private static string GetCellReference(int colIndex)
    {
        int dividend = colIndex;
        string columnName = String.Empty;

        while (dividend > 0)
        {
            int modifier = (dividend - 1) % 26;
            columnName = Convert.ToChar(65 + modifier) + columnName;
            dividend = (dividend - modifier) / 26;
        }

        return columnName;
    }
}