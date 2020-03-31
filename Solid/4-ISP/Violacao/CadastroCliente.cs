using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.ISP.Violacao
{
	public class CadastroCliente : ICadastro
	{
		public void EnviarEmail()
		{
			// Envia e-mail de boas vindas
		}

		public void SalvarBanco()
		{
			// Insere no banco de dados
		}

		public void ValidarDados()
		{
			// validar CPF, E-mail, etc.
		}
	}
}
