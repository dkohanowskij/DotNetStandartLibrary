using System;

namespace TestLib
{
  public class UserManager
  {
    private string _name;

    public string Name {
      get => _name;
      set => _name = value;
    }

    public UserManager(string name)
    {
      _name = name;
    }
    
    public string GetGreeting()
    {
      return DateTime.Now.ToShortDateString() + $" Hello, {_name}! ";
    }
  }
}
