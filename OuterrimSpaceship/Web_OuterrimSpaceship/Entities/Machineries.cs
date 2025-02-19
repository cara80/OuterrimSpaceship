using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_OuterrimSpaceship.Entities;

public class Machineries
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MachineryId { get; set; }
    public string Label { get; set; }
    public string Function { get; set; }

    public int CompartmentId { get; set; }
}