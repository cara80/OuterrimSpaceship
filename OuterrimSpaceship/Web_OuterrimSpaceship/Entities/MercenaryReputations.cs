using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_OuterrimSpaceship.Entities;

[Table("Mercenary_Reputations")]
public class MercenaryReputations
{
    [Key]
    public int SyndicateId { get; set; }
    [Key]
    public int MercenaryId { get; set; }
    public string ReputationChange { get; set; }
    
    [ForeignKey("SyndicateId")]
    public CrimeSyndicates Syndicate { get; set; }
    
    [ForeignKey("MercenaryId")]
    public Mercenaries Mercenary { get; set; }
}