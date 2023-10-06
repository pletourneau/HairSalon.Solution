namespace HairSalon.Models
{
  public class Client
  {
    public string Name { get; set; }
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public string Details { get; set; }
    public Stylist Stylist { get; set; }
  }
}