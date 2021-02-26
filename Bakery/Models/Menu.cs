namespace Menu.Models 
{
  public class Bread
  {
    public int BreadCount{get; set;}
    public Bread(int breadcount)
    {
      BreadCount = breadcount;
    }
    public int BreadCost()
    {
      int breadcost = 0;
      for(int i=1;i<=BreadCount;i++)
      {
        if(!(i%3==0))
        {
          breadcost += 5;
        }
      }
      return breadcost;
    }
  }
  public class Pastry
  {
    public int PastryCount{get; set;}
    public Pastry(int pastrycount)
    {
      PastryCount = pastrycount;
    }
    public int PastryCost()
    {
      int pastrycost = 0;
      for(int i=1;i<=PastryCount;i++)
      {
        if(!(i%3==0))
        {
          pastrycost += 2;
        }
        else
        {
          pastrycost += 1;
        }
      }
      return pastrycost;
    }
  }
}