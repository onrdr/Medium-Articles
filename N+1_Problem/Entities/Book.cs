using System.Text.Json.Serialization;

namespace WebApi.Entities;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int YearOfPublication { get; set; }

    public int AuthorId { get; set; }
    [JsonIgnore]
    public virtual Author Author { get; set; }
}