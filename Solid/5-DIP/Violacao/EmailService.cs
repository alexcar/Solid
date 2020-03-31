
namespace Solid.DIP.Violacao
{
	public static class EmailService
	{
		public static bool IsValid(string input)
		{
			return !string.IsNullOrEmpty(input);
		}

		public static void Enviar(
			string emailFrom, 
			string emailTo,
			string emailAssunto,
			string emailCorpo
			)
		{
			// Envia o e-mail.
		}
	}
}
