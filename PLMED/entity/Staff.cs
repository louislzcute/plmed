﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLMED.entity
{
    internal class Staff : Entity
    {
        public int id { get; set; }
        public String Name { get; set; }

        public Table getTable()
        {
            return Table.StaffTable;
        }
    }
}
