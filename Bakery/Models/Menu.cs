namespace Menu.Models 
{
  public class Bread
  {
    public int BreadCount{get; set;}
    public Bread(int breadcount)
    {
      BreadCount = breadcount;
    }
  }
  public class Pastry
  {
    public int PastryCount{get; set;}
    public Pastry(int pastrycount)
    {
      PastryCount = pastrycount;
    }
  }
}