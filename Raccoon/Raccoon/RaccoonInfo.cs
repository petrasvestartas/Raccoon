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

using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace Raccoon
{
    public class RaccoonInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "Raccoon";
            }
        }

        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return Properties.Resources.simulation;
            }
        }

        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "Grasshopper plug-in for IBOIS CNC machine";
            }
        }

        public override Guid Id
        {
            get
            {
                return new Guid("7da10181-1c7b-4eeb-8221-b5aa4807c5b4");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "Petras Vestartas";
            }
        }

        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "petrasvestartas@gmail.com";
            }
        }
    }
}