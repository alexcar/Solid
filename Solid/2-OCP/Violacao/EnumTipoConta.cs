using System.ComponentModel;

namespace Solid.OCP.Violacao
{
	public enum EnumTipoConta
	{
		[Description("ContaCorrente")] ContaCorrente,
		[Description("ContaPoupanca")] ContaPoupanca,
		[Description("ContaInvestimento")] ContaInvestimento,
	}
}
