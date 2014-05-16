using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    // Exercise 04 Made new class that inherits the engine one with a ne method in it
    public class PatchedEngine : Engine
    {

        public PatchedEngine(IRenderer renderer, IUserInterface userInterface, int threadSleeper = 50) : base(renderer, userInterface, threadSleeper)
        {
        }

        public void ShootPlayerRacket() 
        {
        }
    }
}
