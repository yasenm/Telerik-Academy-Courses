using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Giant : Character, IFighter, IGatherer
    {
        private bool GatheredStone = false;

        public Giant(string name, Point position, int owner = 0)
            : base(name, position, owner)
        {
            this.HitPoints = 200;
        }

        private int attackPoints;
        public int AttackPoints
        {
            get { return this.attackPoints; }
            private set { this.attackPoints = 150; }
        }

        public int DefensePoints
        {
            get { return 80; }
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (this.GatheredStone != true)
                {
                    this.attackPoints += 150;
                }
                this.GatheredStone = true;
                return true;
            }

            return false;
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner)
                {
                    return i;
                }

                return -1;
            }

            return -1;
        }
    }
}
