using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace KPSF.Output
{
    public class Excel
    {
        string path = "";
        static _Application excel = new Microsoft.Office.Interop.Excel.Application();
        static Workbook wb;
        static Worksheet ws;

        public Excel(string path, int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }

        public void WriteToCell(int i, int j, string s)
        {
            i++;
            j++;
            ws.Cells[i, j].Value2 = s;
        }

        public void Save()
        {
            wb.Save();
        }

        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }

        public void Close()
        {
            wb.Close();  
        }
    }
}
