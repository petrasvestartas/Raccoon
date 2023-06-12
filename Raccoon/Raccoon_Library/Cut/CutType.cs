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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raccoon_Library
{
    public enum CutType
    {
        Cut = 0,

        Mill = 1,
        Drill = 2,
        SawBlade = 3,
        SawBladeBisector = 4,
        Engrave = 5,
        MillPath = 6,
        MillCircular = 7,
        SawCircular = 8,
        SawEnd = 9,
        Slice = 10,
        SawBladeSlice = 11,
        OpenCut = 12,
    }
}