using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_OuterrimSpaceship.Entities;

public class Mercenaries
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MercenaryId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int BodySkills { get; set; }
    public int CombatSkill { get; set; }
}