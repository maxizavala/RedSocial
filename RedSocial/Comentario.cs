

namespace RedSocial
{
	public class Comentario


	{
		public int Id { get; set; }
		public Post Post { get; set; }
		public Usuario Usuario { get; set; }
		public string Contenido { get; set; }
		public DateTime Fecha { get; set; }

		public Comentario(int Id, Post Post, Usuario usuario, string Contenido, DateTime Fecha)
		{

			this.Id = Id;
			this.Post = Post;
			this.Usuario = usuario;
			this.Contenido = Contenido;
			this.Fecha = Fecha;

		}


	}
}
