using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyFxApp
{
    public class NancyFxModule: NancyModule
    {
        public NancyFxModule()
        {
            Get["/"] = param => View["Index.html"];
        }

    }
}