using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    class ReadExcel
    {
        public static void data()
        {
            string filepath = @"C:\Users\poluv\Downloads\Sampleexce.xlsx";
            string extension = Path.GetExtension(filepath);
            try
            {
                IWorkbook workbook = null;
                FileStream fileinput = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                ISheet sheet = null;

                Console.WriteLine(extension);
                if (extension == ".xlsx")
                {
                    workbook = new XSSFWorkbook(fileinput);
                }

                else if (extension == ".xls")
                {
                    workbook = new HSSFWorkbook(fileinput);
                }

                sheet = workbook.GetSheetAt(0);
                if (sheet != null)
                {
                    int rowcount = sheet.LastRowNum;
                    for (int i = 1; i <= rowcount; i++)
                    {
                        IRow currentrow = sheet.GetRow(i);                          // rowvalue 1,2,3,..
                        var cellvalue = currentrow.GetCell(0).StringCellValue;      //columnvalue 0
                        Console.WriteLine(cellvalue);
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
