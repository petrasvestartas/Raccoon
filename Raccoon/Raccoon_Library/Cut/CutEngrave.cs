﻿using Rhino.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raccoon_Library
{
    public class CutEngrave : Cut
    {
        public CutEngrave(int id, CutType cutType, Plane refPlane, List<Plane> planes) : base(id, cutType, refPlane, planes)
        {//, List<double> speeds, int smooth //, speeds, smooth
        }
    }
}