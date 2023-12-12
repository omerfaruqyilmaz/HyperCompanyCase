using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperCompanyCase.Entities.Entity
{
    [Table("Colors")]
    public class Color : BaseEntity
    {
        [StringLength(50)] public string Name { get; set; }
    }
}
