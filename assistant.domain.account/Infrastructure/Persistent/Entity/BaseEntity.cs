using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assistant.domain.account.Infrastructure.Persistent.Entity;

public class BaseEntity
{
    [Column("id", TypeName = "int")]
    [Required]
    [Key]
    [Comment("Main key")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("is_deleted", TypeName = "bool")]
    [Required]
    [Comment("Logic delete")]
    public bool IsDeleted { get; set; }

    [Column("create_time", TypeName = "DateTime")]
    [Required]
    [Comment("The time of create")]
    public DateTime CreateTime { get; set; }

    [Column("update_time", TypeName = "DateTime")]
    [Required]
    [Comment("The time of update")]
    public DateTime UpdateTime { get; set; }
}
