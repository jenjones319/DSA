using System;

namespace DataStructures.LinkedLists
{
    public class OutOfRangeException : Exception
    {
        public OutOfRangeException(int val)
            : base($"{val}")
        {

        }
    }
}
