using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Meergo.Model;

namespace Meergo.Flush
{
    class ActionSizeCalculator
    {
        public static int Calculate(BaseAction action)
        {
            return JsonConvert.SerializeObject(action).Length;
        }
    }
}
