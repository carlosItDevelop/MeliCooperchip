using System;

namespace SDK
{
	public class AuthorizationException : Exception
	{
		public AuthorizationException ()
		{
		}

		public AuthorizationException(string msg, Exception ex) : base(msg, ex) {
		}
	}
}

