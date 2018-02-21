using System;
using System.IO;
using generateFeedTextFromExcel.Feed;
using Excel = OfficeOpenXml;
using OfficeOpenXml.Style;

namespace generateFeedTextFromExcel
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string filePath = args[0];
            string feedType = args[1];
            Console.WriteLine(filePath);
            Console.WriteLine(feedType);

            int startRow = 2;
            int pidCol = 1;
            int titleCol = 2;

            try{
                
                //ファイルパスのチェック
                if(!File.Exists(filePath)) {
                    Console.WriteLine("指定されたファイルが存在しません。");
                    return;
                }
                
                //Feedのタイプをチェック
                if(feedType != Pla.PLA) {
                    Console.WriteLine("指定されたFeedのタイプが無効です。");
                    return;
                }
                Excel.ExcelPackage exApp = new Excel.ExcelPackage(new FileInfo(filePath));
                Excel.ExcelWorksheet ws = exApp.Workbook.Worksheets[1];

                int getRow = 0;
                while (true)
                {
                    string pid = ws.Cells[startRow + getRow, pidCol].Text;
                    string title = ws.Cells[startRow + getRow, titleCol].Text;
                    Feed.Pla pla = new Feed.Pla(pid, title);

                    if (pla.Title.Equals(""))
                    {
                        break;
                    }
                    Console.WriteLine(string.Format(Pla.outputFormat, pla.Pid.Replace("c", ""), pla.Title));
                    getRow = getRow + 1;
                }

            }catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
