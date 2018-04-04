using System;
namespace generateFeedTextFromExcel.Feed
{
    public abstract class Feed
    {
        private int startRow = 2;
        private int pidCol = 1;
        private int titleCol = 1;
        private string pid = null;
        private string title = null;
        
        public abstract string OutputFormat {
          get;
        }
        public virtual int StartRow { get { return this.startRow; }}
        public virtual int PidCol { get { return this.pidCol; } }
        public virtual int TitleCol { get { return this.titleCol; } }
        public virtual string Pid { get{ return this.pid; } set{ this.pid = value; } }
        public virtual string Title { get{ return this.title; } set{ this.title = value; } }
        public Feed()
        {

        }
    }
}