using System;
using System.Collections.Generic;

namespace Business.Entities;

public partial class Book
{
    public Book() { }

    public Book(int bookId, string bookName, string? bookDescription, string? author, DateTime releaseDate, bool? isActived)
    {
        BookId = bookId;
        BookName = bookName;
        BookDescription = bookDescription;
        Author = author;
        ReleaseDate = releaseDate;
        IsActived = isActived;
    }

    public int BookId { get; set; }

    public string BookName { get; set; } = null!;

    public string? BookDescription { get; set; }

    public string? Author { get; set; }

    public DateTime ReleaseDate { get; set; }

    public bool? IsActived { get; set; }
}
