namespace Menu.Models 
{
  public class Bread
  {
    public int BreadCount{get; set;}
    public Bread(int breadcount)
    {
      BreadCount = breadcount;
    }
    public int BreadTotal(int breadcount)
    {
      int breadtotal = 0;
      for(int i=1;i<=breadcount;i++)
      {
        if(!(i%3==0))
        {
          breadtotal += 5;
        }
      }
      return breadtotal;
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