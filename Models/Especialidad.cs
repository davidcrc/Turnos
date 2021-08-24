using System.ComponentModel.DataAnnotations;

// Declaramos un namespace para poder llamarlo en otros lados
namespace Turnos.Models
{
  public class Especialidad
  {
    [Key]
    public int IdEspecialidad { get; set; }
    public string Descripcion { get; set; }
  }
}