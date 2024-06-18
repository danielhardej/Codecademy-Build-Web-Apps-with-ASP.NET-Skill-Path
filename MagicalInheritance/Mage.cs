// Mage.cs
using System;

namespace MagicalInheritance
{
  class Mage : Pupil
  {
    public Mage(string title, string origin) : base(title, origin)
    {}
    public virtual Storm CastRainStorm()
    {
      Storm windStorm = new Storm("rain", false, Title);
      return windStorm;
    }
  }
  
}
