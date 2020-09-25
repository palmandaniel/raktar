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


		public Megrendeles(string datum, string id, string email)
		{
			this.datum = datum;
			this.id = id;
			this.email = email;
		}

	}
}
