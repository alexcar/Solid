using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.SRP.Correto
{
	public interface IConnection
	{
		public void Dial(string pno);
		public void Hangup();
	}
}
