using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDB
{
  public class Visitor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeptor { get; set; }
        public virtual IEnumerable<Book> Books { get; set; }

    }
}
