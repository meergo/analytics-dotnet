using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meergo.Exception
{
    public class NotInitializedException : System.Exception
    {
        public NotInitializedException() : base("Please initialize Meergo.io first before using.") { }

    }
}
