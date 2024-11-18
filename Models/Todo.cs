using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cadastro.Models;

public class Todo
{
public int Id { get; set; }
[DisplayName ("Título")]
[Required(ErrorMessage ="Nome obrigatorio")]
public required string Title { get; set; }
[DisplayName("Concluído")]
public bool Done { get; set; }
[DisplayName("Criada em ")]
public DateTime CreatedAt { get; set; } = DateTime.Now;
[DisplayName("Última atualização")]
public DateTime LastUpdate { get; set; }= DateTime.Now;
[Required]
public string User { get; set; }

}
