using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.DIP.Violacao
{
	/// <summary>
	/// Classe cliente dependendo de uma implementação direta de 
	/// EmailServices e CPFServices. Qualquer uma dessas duas classes 
	/// mudarem, é necessário alteração na classe Cliente.
	/// </summary>
	public class Cliente
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string Cpf { get; set; }
		public DateTime DataCadastro { get; set; }

		public bool IsValid()
		{
			return EmailService.IsValid(Email) && CpfServices.IsValid(Cpf);
		}
	}
}
