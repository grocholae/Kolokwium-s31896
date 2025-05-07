namespace Kolokwium_APBD_s31896.Models.DTOs;

public class PrzynaleznoscGetDTO
{
    public string Nazwa { get; set; }
    public string Skrot { get; set; }
    public DateTime DataZalozenia { get; set; }
    public DateTime DataOd { get; set; }
    public DateTime? DataDo { get; set; }
}