﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet.cs
{
    class NNException : Exception
    {
        public NNException()
        {
        }

        public NNException(string message) : base(message)
        {
        }

        public NNException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NNException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
