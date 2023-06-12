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
    public static class GlobalParameters
    {
        public static bool sort_rectangular_tool_path_by_edge_length = false;

        public static int zero_point = 54;

        public static double z_safety = 750;

        public static bool orient_to_zero_after_each_cut = true;

        public static bool skirt_down = false;
    }

    public static class Axes
    {
        public const char X = 'X';
        public const char Y = 'Y';
        public const char Z = 'Z';
        public const double XCoord = 0;
        public const double YCoord = 0;
        public static double ZCoord = GlobalParameters.z_safety;
        public const char A = 'C';
        public const char B = 'A';
        public const char C = 'B';
        public const string DefaultRotation = " C0 A0";
        public static string HomePosition2 = " X5000 Y-2000 Z" + GlobalParameters.z_safety.ToString();
        public static string HomePosition = " X0 Y0 Z" + GlobalParameters.z_safety.ToString();//" X5000 Y-2000 Z800";
    }
}