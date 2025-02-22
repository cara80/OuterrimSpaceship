using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_OuterrimSpaceship.Entities;

[Table("Energy_Systems")]
public class EnergySystems
{
    [Key, ForeignKey("MachineryId")]
    public int MachineryId { get; set; }
}