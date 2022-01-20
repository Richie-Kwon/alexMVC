using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace alexMVC.Models
{
    [Table("authors")]
    public class Author
    {
        [Key]
        public string name { get; set; }
        public string address { get; set; }
        
    }
}