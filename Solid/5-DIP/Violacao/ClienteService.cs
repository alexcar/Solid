
namespace Solid.DIP.Violacao
{
	/// <summary>
	/// Classe ClienteService dependendo diretamente da classe 
	/// ClienteRepository.
	/// </summary>
	public class ClienteService
	{
		public string AdicionarCliente(Cliente cliente)
		{
			if (!cliente.IsValid())
				return "Dados Inválido";

			var repo = new ClienteRepository();
			repo.AdicionarCliente(cliente);

			EmailService.Enviar(
				"contato@empresa.com.br"
				, cliente.Email,
				"Bem-vindo",
				"Para teste"
				);

			return "Cliente cadastrado com sucesso";
		}
	}
}
