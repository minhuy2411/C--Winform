using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO;

public partial class BookDTO
{
    public int BookId { get; set; }

    public string BookName { get; set; } = null!;

    public string? BookDescription { get; set; }

    public string? Author { get; set; }

    public DateTime ReleaseDate { get; set; }

}
