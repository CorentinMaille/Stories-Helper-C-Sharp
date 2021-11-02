using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoriesHelper.Services
{
    class Session
    {
        protected int idOrganization;

        public Session(int id)
        {
            this.idOrganization = id;
        }
    }
}
