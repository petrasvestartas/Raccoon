///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// DEVELOPER:
// Petras Vestartas, petasvestartas@gmail.com
// Funding: EPFL
//
// HISTORY:
// 1) The first CNC Maka code was written in IronPython by Benjamin Hahn. Thesis: Upscaling of Friction Welding of Wood for Structural Applications 2014
// 2) The second version was turned in a C# plugin by Christropher Robeller. Thesis: Integral Mechanical Attachment for Timber Folded Plate Structures 2015
// 3) The third version was written during Robotic and CNC software development by Petras Vestartas. Thesis: Design-to-Fabrication Workflow for Raw-Sawn-Timber using Joinery Solver, 2021
//
// RESTRICTIONS:
// The code cannot be used for commercial reasons
// If you would like to use or change the code for research or educational reasons,
// please contact the developer first
//
// 3RD PARTY LIBRARIES:
// Rhino3D
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using Rhino.Geometry;
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