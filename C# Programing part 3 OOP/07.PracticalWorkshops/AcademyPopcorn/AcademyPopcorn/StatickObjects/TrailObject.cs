using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    // Exercise 05 Implementing TrailObject
    class TrailObject : GameObject
    {
        private int Lifetime;

        public TrailObject(MatrixCoords upperLeft, char[,] body, int lifetime = 30)
            : base(upperLeft, body)
        {
            this.Lifetime = lifetime;
        }

        public override void Update()
        {
            this.Lifetime--;
            if (this.Lifetime <= 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
