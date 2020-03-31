using System;

namespace Solid.ISP.Violacao
{
	public class CadastroProduto : ICadastro
	{
		public void EnviarEmail()
		{
			// produto não tem e-mail, o que faço agora?
			throw new NotImplementedException("Esse método não serve para nada!");
		}

		public void SalvarBanco()
		{
			// Insere no banco de dados
		}

		public void ValidarDados()
		{
			// validar valor, etc.
		}
	}
}
