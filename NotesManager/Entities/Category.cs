using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace NotesManager.Entities;

[Index("ParentId", "UserId")]
public class Category
{
    public int Id { get; set; }

    [Required] //если не установить значение св-ва, то будет ошибка Microsoft.EntityFrameworkCore.DbUpdateException
    [MaxLength(100)]
    public string Name { get; set; }


    public int? ParentId { get; set; }
    public Category? Parent { get; set; }
    public List<Category> Children { get; set; } = new List<Category>();

    //public int? UserId { get; set; } // св-во внешнего ключа
    //public UserProfile? User { get; set; } // навигационное св-во

    public List<UserProfile> Users { get; set; } // навигационное св-во
}
