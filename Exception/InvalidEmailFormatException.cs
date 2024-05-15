using System;
namespace CareerHub.Exception
{
	public class InvalidEmailFormat : FormatException
	{
		public InvalidEmailFormat()
		{
		}
        public InvalidEmailFormat(string msg): base(msg)
        {
        }
    }
}

