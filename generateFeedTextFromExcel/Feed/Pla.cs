using System;
namespace generateFeedTextFromExcel.Feed
{
    public class Pla
    {
        public const string PLA = "pla";
        public const string outputFormat = "'{0}' => '{1}',";

        private string pid = null;
        private string title = null;

        public string Pid { get { return this.pid; } set { this.pid = value; } }
        public string Title { get { return this.title; } set { this.title = value; } }

        public Pla()
        {

        }

        public Pla(string pid, string title)
        {
            this.Pid = pid;
            this.Title = title;
        }
    }
}
