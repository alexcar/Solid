using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.OCP.Violacao
{
	public class DebitoConta
	{
		public void Debitar(
			decimal valor, string conta, string tipoConta)
		{

			if (tipoConta == TipoConta.ContaCorrente)
			{
				// Debita conta corrente
			}
			else if (tipoConta == TipoConta.ContaPoupanca)
			{
				// Debita conta poupança
			}
		}
	}
}
