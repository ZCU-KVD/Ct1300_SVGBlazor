namespace SVGBlazor.Models
{
	public class Kruh : Obrazec
	{
		public int Polomer { get; set; }

		public override string Vykresli() 
		{
			return $"<circle r=\"{Polomer}\" cx=\"{X}\" cy=\"{Y}\" fill=\"{Barva}\" stroke=\"{(Vybrany ? "black" : "none")} \" stroke-width=\"3\" />";
		}
	}
}
