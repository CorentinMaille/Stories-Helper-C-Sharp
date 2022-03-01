using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoriesHelper.Models
{
    class LogHistory : Model
    {
        protected int rowid;
        protected int fk_author;
        protected DateTime date_creation;
        protected string action;
        protected string object_type;
        protected string object_name;
        protected string value;
        protected string identification;
        protected string platform;
        protected string status;

        public LogHistory()
        {
       
        }

        public void initialize(int rowid, int fk_author, DateTime date_creation, string action, string object_type, string object_name, string value, string identification, string platform, string status)
        {
            this.rowid          = rowid;
            this.fk_author      = fk_author;
            this.date_creation  = date_creation;
            this.action         = action;
            this.object_type    = object_type;
            this.object_name    = object_name;
            this.value          = value;
            this.identification = identification;
            this.platform       = platform;
            this.status         = status;
        }

        public int getRowid()
        {
            return rowid;
        }

        public int getFk_author()
        {
            return fk_author;
        }

        public DateTime getDate_creation()
        {
            return date_creation;
        }

        public string getAction()
        {
            return action;
        }

        public string getObject_type()
        {
            return object_type;
        }

        public string getObject_name()
        {
            return object_name;
        }

        public string getValue()
        {
            return value;
        }

        public string getIdentification()
        {
            return identification;
        }

        public string getPlatform()
        {
            return platform;
        }

        public string getStatus()
        {
            return status;
        }
    }
}
