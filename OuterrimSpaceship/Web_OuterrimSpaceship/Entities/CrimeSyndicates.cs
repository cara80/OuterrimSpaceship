using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_OuterrimSpaceship.Entities;

[Table("Crime_Syndicates")]
public class CrimeSyndicates
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SyndicateId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
}