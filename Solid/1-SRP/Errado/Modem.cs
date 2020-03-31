using System;

namespace Solid.SRP.Errado
{
	public class Modem : IModem
	{
		public void Dial(string pno)
		{
			throw new NotImplementedException();
		}

		public void Hangup()
		{
			throw new NotImplementedException();
		}

		public char Recev()
		{
			throw new NotImplementedException();
		}

		public void Send(char c)
		{
			throw new NotImplementedException();
		}
	}
}
