namespace HairSalon.Models
{
  public class Client
  {
    public string Name { get; set; }
    public int Id { get; set; }
    public int StylistId { get; set; }
    public string Detail { get; set; }
    public Stylist Stylist { get; set; }
  }
}