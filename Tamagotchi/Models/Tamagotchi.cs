using System;
using System.Collections.Generic;

namespace Tamagotchis.Models
{
  public class Tamagotchi
  {
    public string name {get; set;}
    public int food {get; set;}
    public int attention {get; set;}
    public int rest {get; set;}

    private static int _passDecrease = 0;

    public int id {get;}
    private static List<Tamagotchi> _instances = new List<Tamagotchi> {};

    public Tamagotchi(string newName)
    {
      name = newName;
      food = 100 + _passDecrease;
      attention = 100 + _passDecrease;
      rest = 100 + _passDecrease;
      _instances.Add(this);
      id = _instances.Count;
    }
    public static void Delete(Tamagotchi newTamagotchi)
    {
      _instances.Remove(newTamagotchi);
    }
    public static Tamagotchi Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static List<Tamagotchi> GetAll()
    {
      return _instances;
    }
    public void Feed()
    {
      this.food += 15;
    }
    public void Play()
    {
      this.attention += 20;
    }
    public void Sleep()
    {
      this.rest += 10;
    }
    public static void PassTime(Tamagotchi newTamagotchi)
    {
       newTamagotchi.food -= 5;
       newTamagotchi.attention -= 5;
       newTamagotchi.rest -= 5;
      
    }
  }
}
