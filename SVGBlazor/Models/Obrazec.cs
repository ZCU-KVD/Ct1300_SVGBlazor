namespace SVGBlazor.Models
{
	public abstract class Obrazec
	{
		public int X { get; set; }
		public int Y { get; set; }
		public string Barva { get; set; } = "blue";

		public abstract string Vykresli();
		
	}
}
