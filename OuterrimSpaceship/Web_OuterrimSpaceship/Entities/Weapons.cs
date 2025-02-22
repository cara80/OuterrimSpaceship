using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_OuterrimSpaceship.Entities;

[Table("Weapons")]
public class Weapons
{
    [Key, ForeignKey("MachineryId")]
    public int MachineryId { get; set; }
}