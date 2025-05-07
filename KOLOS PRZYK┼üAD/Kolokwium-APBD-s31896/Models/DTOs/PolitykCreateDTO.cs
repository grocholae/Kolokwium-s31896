using System.ComponentModel.DataAnnotations;

namespace Kolokwium_APBD_s31896.Models.DTOs;

public class PolitykCreateDTO
{
   [Required]
    public string Imie { get; set; }
    [Required]
    public string Nazwisko { get; set; }
    [Required]
    public string Powiedzenie { get; set; }
}