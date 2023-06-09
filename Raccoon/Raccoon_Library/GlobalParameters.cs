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