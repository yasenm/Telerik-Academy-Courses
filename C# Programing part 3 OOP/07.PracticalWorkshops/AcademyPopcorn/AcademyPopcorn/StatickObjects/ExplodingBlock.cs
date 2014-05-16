using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ExplodingBlock : Block
    {
        public const char Symbol = 'X';
        public new const string CollisionGroupString = "explodingBlock";

        public ExplodingBlock(MatrixCoords upperLeft) : base(upperLeft)
        {
            this.body[0, 0] = ExplodingBlock.Symbol;
        }

        public override string GetCollisionGroupString()
        {
            return Block.CollisionGroupString;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "ball";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();
            if (this.IsDestroyed)
            {
                producedObjects.Add(new Explosion(this.topLeft, new char[,] { { '*' } }, new MatrixCoords(-1, 0)));
                producedObjects.Add(new Explosion(this.topLeft, new char[,] { { '*' } }, new MatrixCoords(1, 0)));
                producedObjects.Add(new Explosion(this.topLeft, new char[,] { { '*' } }, new MatrixCoords(0, 1)));
                producedObjects.Add(new Explosion(this.topLeft, new char[,] { { '*' } }, new MatrixCoords(0, -1)));
                //producedObjects.Add(new TrailObject(new MatrixCoords(this.GetTopLeft().Row - 1, this.GetTopLeft().Col), new char[,] { { '*' } }, 1));
                //producedObjects.Add(new TrailObject(new MatrixCoords(this.GetTopLeft().Row - 1, this.GetTopLeft().Col + 1), new char[,] { { '*' } }, 1));
                //producedObjects.Add(new TrailObject(new MatrixCoords(this.GetTopLeft().Row, this.GetTopLeft().Col + 1), new char[,] { { '*' } }, 0));
                //producedObjects.Add(new TrailObject(new MatrixCoords(this.GetTopLeft().Row, this.GetTopLeft().Col - 1), new char[,] { { '*' } }, 0));
                //producedObjects.Add(new TrailObject(new MatrixCoords(this.GetTopLeft().Row - 1, this.GetTopLeft().Col - 1), new char[,] { { '*' } }, 1));
                //producedObjects.Add(new TrailObject(new MatrixCoords(this.GetTopLeft().Row, this.GetTopLeft().Col - 1), new char[,] { { '*' } }, 1));
                //producedObjects.Add(new TrailObject(new MatrixCoords(this.GetTopLeft().Row + 1, this.GetTopLeft().Col - 1), new char[,] { { '*' } }, 1));
            }
            return producedObjects;
        }
    }
}
