using System.ComponentModel.DataAnnotations;

namespace ItGeek.DAL.Entities;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
}
