using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assistant.domain.account.Infrastructure.Persistent.Entity;

[Table("tbl_user")]
public class UserEntity : BaseEntity
{
    [Column("user_name")]
    [Required]
    public string UserName { get; set; }

    [Column("phone_num", TypeName = "varchar(30)")]
    public string PhoneNum { get; set; }

    [NotMapped]
    public bool IsTest { get; set; }
}