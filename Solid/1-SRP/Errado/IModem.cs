
namespace Solid.SRP.Errado
{
	public interface IModem
	{
		public void Dial(string pno);
		public void Hangup();
		public void Send(char c);
		public char Recev();
	}
}
