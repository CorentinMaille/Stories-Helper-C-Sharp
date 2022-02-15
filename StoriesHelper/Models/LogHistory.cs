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

        public LogHistory()
        {
       
        }

        public void initialize(int rowid, int fk_author, DateTime date_creation, string action, string object_type, string object_name, string value, string identification)
        {
            this.rowid          = rowid;
            this.fk_author      = fk_author;
            this.date_creation  = date_creation;
            this.action         = action;
            this.object_type    = object_type;
            this.object_name    = object_name;
            this.value          = value;
            this.identification = identification;
        }

    }
}
