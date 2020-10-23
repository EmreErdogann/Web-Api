using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Todo")]
    public class Todo
    {
        //Burda Data annotations kullandım Proje büyük olursa fluenapi da kullanılabilir

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(400)]
        public string Description { get; set; }
    }
}
