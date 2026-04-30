namespace SVGBlazor.Models
{
	public abstract class Obrazec
	{
		public int X { get; set; }
		public int Y { get; set; }
		public string Barva { get; set; } = "blue";
		public bool Vybrany { get; set; } = false;
		public abstract string Vykresli();

		public void Posun(int dx, int dy)
		{
			X += dx;
			Y += dy;
		}

	}
}
