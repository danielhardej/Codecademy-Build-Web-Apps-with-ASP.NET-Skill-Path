// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm : Spell
  {
    public Storm(string essence, bool isStrong, string caster)
    {
      Essence = essence;
      IsStrong = isStrong;
      Caster = caster;
    }

    public override void Announce()
    {
      if (IsStrong)
      {
        Console.WriteLine($"{Caster} cast a strong {Essence} storm!");
      }
      else
      {
        Console.WriteLine($"{Caster} cast a weak {Essence} storm!");
      }
    }
  }
}
