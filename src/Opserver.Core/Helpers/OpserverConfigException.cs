﻿using System;

namespace Opserver.Helpers
{
    public class OpserverConfigException : Exception
    {
        public OpserverConfigException() { }
        public OpserverConfigException(string message) : base(message) { }
        public OpserverConfigException(string message, Exception innerException) : base(message, innerException) { }
    }
}
