using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace WSCSharpJazz
{
    public class WSCSharpJazzInfo : GH_AssemblyInfo
    {
        public override string Name => "WSCSharpJazz";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("9D5FF396-2030-4E5E-B693-D19E137B476E");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}