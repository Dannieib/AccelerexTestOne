# AccelerexTestOne
Part 2: Tell us what do you think about the data format. Is the current JSON structure the best
way to store that kind of data or can you come up with a better version?


Solution: No, not the right way. Atleastn might be ok but not flexible. 

Something like this would be simple and flexible

public class Days
{
  public string Day {get;set;} //Monday,Tuesday,Wednesday ...
  public int Hours {get;set;}
  public string value {get;set;}
}

When passing into a function/method, could be:
public void Type MethodName (List<Days> days)
{
}
