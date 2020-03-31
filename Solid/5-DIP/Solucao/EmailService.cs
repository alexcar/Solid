using System.Net.Mail;

namespace Solid.DIP.Solucao
{
	public class EmailService : IEmailService
	{
		public void Enviar(string de, string para, string assunto, string mensagem)
		{
			var mail = new MailMessage(de, para);
			var client = new SmtpClient
			{
				Port = 25,
				DeliveryMethod = SmtpDeliveryMethod.Network,
				UseDefaultCredentials = false,
				Host = "smtp.empresa.com.br"
			};

			mail.Subject = assunto;
			mail.Body = mensagem;
			client.Send(mail);
		}

		public bool IsValid(string email)
		{
			return email.Contains("@");
		}
	}
}
