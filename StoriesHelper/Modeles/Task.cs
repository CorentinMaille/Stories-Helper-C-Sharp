﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace StoriesHelper.Modeles
{
    class Task
    {
        private int rowid;
        private string name;
        private string description;
        private int fk_column;
        private int rank;
        private int fk_author;
        private bool admin;
        private bool active;

        public Task(int taskId = -1)
        {
            if(taskId != -1)
            {

            }
        }
    }
}
