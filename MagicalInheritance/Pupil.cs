// Pupil.cs
using System;

namespace MagicalInheritance
{
    class Pupil(string title, string origin)
    {
        public string Title { get; private set; } = title;
        public string Origin { get; private set; } = origin;

        public Storm CastWindStorm()
        {
          Storm windStorm = new Storm("wind", false, Title);
          return windStorm;
        }
    }
}
