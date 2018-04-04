using System;
namespace generateFeedTextFromExcel.Feed
{
    public class Pla : Feed
    {
        public const string PLA = "pla";
        private string pid = null;
        private string title = null;
        private int startRow = 2;
        private int pidCol = 1;
        private int titleCol = 1;
        public override string Pid { 
          get { 
            return this.pid.Replace("c", ""); 
          } 
          set { this.pid = value; } 
        }

        public override string OutputFormat{
          get {
            return "'{0}' => '{1}',";
          }
        } 

        public override string Title { get { return this.title; } set { this.title = value; } }
        public override int StartRow { get { return this.startRow; } }
        public override int PidCol { get { return this.pidCol; } }
        public override int TitleCol { get { return this.titleCol; } }
        public Pla()
        {

        }
    }
}
