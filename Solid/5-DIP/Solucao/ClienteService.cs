
namespace Solid.DIP.Solucao
{
	public class ClienteService : IClienteService
	{
		private readonly IClienteRepository _clienteRepository;
		private readonly IEmailService _emailService;

		public ClienteService(
			IClienteRepository clienteRepository,
			IEmailService emailService
			)
		{
			_clienteRepository = clienteRepository;
			_emailService = emailService;
		}
		
		public string AdicionarCliente(Cliente cliente)
		{
			if (!cliente.IsValid())
				return "Dados inválidos";

			_clienteRepository.AdicionarCliente(cliente);
			_emailService.Enviar(
				"contato@empresa.com.br"
				, cliente.Email,
				"Bem-vindo",
				"Para teste"
				);

			return "Cliente cadastrado com sucesso";
		}
	}
}
