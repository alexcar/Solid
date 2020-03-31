
namespace Solid.OCP.Solucao
{
	public class DebitaContaInvestimento : DebitoConta
	{
		public override string Debitar(decimal valor, string conta)
		{
			// Debita conta investimento
			return FormatarTransacao();
		}
	}
}
