﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLMED.entity
{
    internal class Product : Entity
    {
        public Table getTable()
        {
            return Table.ProductTable;
        }
    }
}
