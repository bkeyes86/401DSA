using System;

namespace DataStructures.LinkedList
{
    public class ValueMissingException : ArgumentException
    {
        public ValueMissingException(int missingValue)
            : base($"Value {missingValue} is missing.")
        {
        }
    }
}