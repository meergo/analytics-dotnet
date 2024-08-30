using System;
using System.Collections.Generic;

using Meergo.Model;

namespace Meergo.Flush
{
    internal class SimpleBatchFactory : IBatchFactory
    {
        private string _writeKey;

        internal SimpleBatchFactory (string writeKey)
        {
            this._writeKey = writeKey;
        }

        public Batch Create(List<BaseAction> actions) 
        {
            return new Batch(_writeKey, actions);
        }
    }
}

