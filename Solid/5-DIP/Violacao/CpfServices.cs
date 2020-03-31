
namespace Solid.DIP.Violacao
{
	public static class CpfServices
	{
		public static bool IsValid(string input)
		{
			return !string.IsNullOrEmpty(input);
		}
	}
}
