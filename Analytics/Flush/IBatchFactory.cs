using System;
using System.Collections.Generic;

using Meergo.Model;

namespace Meergo.Flush
{
    internal interface IBatchFactory
    {
        Batch Create(List<BaseAction> actions);
    }
}

