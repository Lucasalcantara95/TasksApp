using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
	[Table("Usuario")] // Esta anotação indica que a classe User está mapeada para a tabela Users no banco de dados.
	public class User
	{
	
		[Key] //Esta anotacão indica que esta propiedade é a chave primaria da entidade User.
		[Required] //Esta anotação indica que esta propriedade é obrigatória.
		public Guid Id { get; set; }

		
		[Required] // Esta anotação indica que esta propriedade é obrigatória.
		[StringLength(50, MinimumLength = 3)] // Esta anotação limita o tamanho máximo da string a 100 caracteres.
		[Column(TypeName = "nvarchar(50)")]
		public string? Name { get; set; }


		[StringLength(50, MinimumLength = 3)]
		[Column(TypeName = "nvarchar(50)")]
		public string? Surname { get; set; }


		[Required] // Esta anotação indica que esta propriedade é obrigatória.
		[EmailAddress]// Esta anotação valida se o formato do email é válido.
		public string? Email { get; set; }

		
		[Required]
		public string? PassswordHash { get; set; }


		[Required]
		public string? Username { get; set; }

		public ICollection<Workspace>? Workspaces { get; set; }

		public string? RefreshToken { get; set; }

		public DateTime RefreshTokenExpiryTime { get; set; }
	}
}
