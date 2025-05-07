namespace Kolokwium_APBD_s31896.Models.DTOs;

public class PolitykGetDTO
{
    public int Id { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Powiedzenie { get; set; }
    public List<PrzynaleznoscGetDTO> Przynaleznosci { get; set; }
}