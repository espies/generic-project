﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProject.Core.Model
{
    public class Relation : LookupModel
    {
        public IList<Peep> Peeps { get; set; }
    }
}
