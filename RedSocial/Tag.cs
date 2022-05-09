using System;
using System.Collections.Generic;


namespace RedSocial
{
	public class Tag
	{

		public int id { get; set; }

		public string palabra { get; set; }

		public List<Post> Posts = new List<Post>();

		public Tag(int id, string palabra)
		{
			this.id = id;
			this.palabra = palabra;
		}
	}
}
