using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.SOLID.L.Bad
{
    internal class Square : Rectangle
    {
        public override double Width {
            get => base.Width;
            set => base.Width = base.Height = value;
        }

        public override double Height {
            get => base.Height;
            set => base.Height = base.Width = value;
        }
    }
}
