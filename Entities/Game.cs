using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Entities;

public class Game
{
    public int Id { get; set; }

    //Validation kuralları tanımlama...
    [Required]//-REQUIRED- boş bırakılamaz alan demek
    [StringLength(50)]//-StringLenght- girilecek karakter sınırı belirler
    public required string Name { get; set; }

    [Required]
    [StringLength(20)]
    public required string Genre { get; set; }

    [Range(1, 100)]//Girilen sayı, belirtilen aralık arasında olmak zorunda 
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }

    [Url]//Url açıklamasını kontrol eder
    [StringLength(100)]
    public required string ImageUri { get; set; }

}