using System.ComponentModel.DataAnnotations;
namespace CRUD_Operation.Models.Base
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
