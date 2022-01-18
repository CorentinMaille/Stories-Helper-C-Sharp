using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Models
{
    class BelongsTo : Model
    {
        int fk_user;
        int fk_team;

        public BelongsTo(int fk_user = 0, int fk_team = 0)
        {
            if(fk_user != 0 && fk_team != 0)
            {
                this.fetch(fk_user, fk_team);
            }
        }

        // SETTER
        public void setUserIds(int user)
        {
            this.fk_user = user;
        }

        public void setTeamIds(int team)
        {
            this.fk_team = team;
        }

        // GETTER
        public int getUserIds()
        {
            return this.fk_user;
        }

        public int getTeamIds()
        {
            return this.fk_team;
        }

        public void fetch(int fk_user, int fk_team)
        {
            this.fk_user = fk_user;
            this.fk_team = fk_team;
        }
    }
}
