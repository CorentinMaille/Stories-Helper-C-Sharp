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
        protected string value = null;
        protected string identification = null;
        protected string status;
        protected string exception = null;
        protected string platform = null;

        public LogHistory()
        {

        }

        public void initialize(int rowid, int fk_author, DateTime date_creation, string action, string object_type, string object_name, string status, string value = null, string identification = null, string exception = null, string platform = null)
        {
            this.rowid = rowid;
            this.fk_author = fk_author;
            this.date_creation = date_creation;
            this.action = action;
            this.object_type = object_type;
            this.object_name = object_name;
            this.value = value;
            this.identification = identification;
            this.status = status;
            this.exception = exception;
            this.platform = platform;
        }

        public int getRowid()
        {
            return rowid;
        }

        public int getFk_author()
        {
            return fk_author;
        }

        public void setFk_author(int fkAuthor)
        {
            this.fk_author = fkAuthor;
        }

        public DateTime getDate_creation()
        {
            return date_creation;
        }

        public void setDate_creation(DateTime DateCreation)
        {
            this.date_creation = DateCreation;
        }

        public string getAction()
        {
            return action;
        }

        public void setAction(string action)
        {
            this.action = action;
        }

        public string getObject_type()
        {
            return object_type;
        }
        
        public void setObject_type(string type)
        {
            this.object_type = type;
        }

        public string getObject_name()
        {
            return object_name;
        }
        
        public void setObject_name(string name)
        {
            this.object_name = name;
        }

        public string getValue()
        {
            return value;
        }
        
        public void setValue(string value)
        {
            this.value = value;
        }

        public string getIdentification()
        {
            return identification;
        }
        
        public void setIdentification(string identification)
        {
            this.identification = identification;
        }

        public string getStatus()
        {
            return status;
        }
        
        public void setStatus(string status)
        {
            this.status = status;
        }

        public string getException()
        {
            return exception;
        }
        
        public void setException(string exception)
        {
            this.exception = exception;
        }

        public string getPlatform()
        {
            return platform;
        }

        public void setPlatform(string platform)
        {
            this.platform = platform;
        }
    }
}