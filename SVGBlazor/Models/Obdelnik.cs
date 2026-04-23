namespace SVGBlazor.Models
{
	public class Obdelnik : Obrazec
	{
		public int Sirka { get; set; }
		public int Vyska { get; set; }

		public override string Vykresli()
		{
			return $"<rect width=\"{Sirka}\" height=\"{Vyska}\" x=\"{X}\" y=\"{Y}\" fill=\"{Barva}\" stroke=\"black\" stroke-width=\"3\" />";
		}
	}
}
