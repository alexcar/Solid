using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.SRP.Correto
{
	public interface IDataChannel
	{
		public void Send(char c);
		public char Recev();
	}
}
