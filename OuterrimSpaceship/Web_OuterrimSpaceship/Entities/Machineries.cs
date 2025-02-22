using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_OuterrimSpaceship.Entities;

[Table("Machineries")]
public class Machineries
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MachineryId { get; set; }
    public string Label { get; set; }
    public string Function { get; set; }
    
    [ForeignKey("CompartmentId")]
    public Compartments Compartment { get; set; }
    public int CompartmentId { get; set; }
}