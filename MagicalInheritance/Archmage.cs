// Archmage.cs
using System;

namespace MagicalInheritance
{
  class Archmage : Mage
  {
    public Archmage(string title, string origin) : base(title, origin)
    {}

    public override Storm CastRainStorm()
    {
      Storm windStorm = new Storm("rain", true, Title);
      return windStorm;
    }

    public Storm CastLightningStorm()
    {
      Storm windStorm = new Storm("lightning", true, Title);
      return windStorm;
    }

  }
  
}
