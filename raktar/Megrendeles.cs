using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raktar
{
    class Megrendeles
    {
		private string datum;

		public string DATUM
		{
			get { return datum; }
			set { datum = value; }
		}

		private string id;

		public string ID
		{
			get { return id; }
			set { id = value; }
		}

		private string email;

		public string EMAIL
		{
			get { return email; }
			set { email = value; }
		}

		private string rendeltek;

		public string RENDELTEK
		{
			get { return rendeltek; }
			set { rendeltek = value; }
		}

		public void TetelHozzaad(string kod, int db)
		{
			tetelek.Add(new Tetel(kod, db));
		}

		private List<Tetel> tetelek;

		private int osszeg;

		public int OSSZEG
		{
			get { return osszeg; }
			set { osszeg = value; }
		}

		private int Ara(string kod, List<Termek> termekek)
		{
			int i = 0;
			while (kod != termekek[i].KOD)
			{
				i++;
			}
			return termekek[i].AR;
		}
		
		public void Szamolas(List<Termek> termekek)
		{
			// kód alapján megkeresni a terméket  -> ár
			//szum += ár * db (annyiszor amennyi termék van)
			int szum = 0;
			for (int i = 0; i < tetelek.Count; i++)
			{
				int ar = Ara(tetelek[i].KOD, termekek);
				szum += ar * tetelek[i].DB;

			}
			this.osszeg = szum;

		}



		public Megrendeles(string datum, string id, string email)
		{
			this.datum = datum;
			this.id = id;
			this.email = email;
			tetelek = new List<Tetel>();
		}

	}
}
