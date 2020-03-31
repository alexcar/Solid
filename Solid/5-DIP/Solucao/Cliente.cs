using System;

namespace Solid.DIP.Solucao
{
	public class Cliente
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string Cpf { get; set; }
		public DateTime DataCadastro { get; set; }

		public bool IsValid()
		{
			// return EmailService.IsValid(Email) && CpfServices.IsValid(Cpf);
			return true;
		}
	}
}
