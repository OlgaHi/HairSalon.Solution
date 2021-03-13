namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public int StylystId { get; set; }
    public virtual Stylyst Stylyst { get; set; }
  }
}