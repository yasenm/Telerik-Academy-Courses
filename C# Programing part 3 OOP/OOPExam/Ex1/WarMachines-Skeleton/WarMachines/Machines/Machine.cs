using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public abstract class Machine : IMachine
    {
        public Machine(string name, double attackPoints, double defensePoints)
        {
            this.name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
        }

        public string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public IPilot pilot;
        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; set; }

        public double DefensePoints { get; set; }

        public IList<string> targets = new List<string>();

        public IList<string> Targets
        {
            get { return this.targets; }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format(" *Health: {0}\n", this.HealthPoints));
            result.Append(String.Format(" *Attack: {0}\n", this.AttackPoints));
            result.Append(String.Format(" *Defense: {0}\n", this.DefensePoints));
            result.Append(" *Targets:");
            if (this.targets.Count > 0)
            {
                foreach (var target in this.Targets)
                {
                    result.Append(String.Format(" {0},", target));
                }
                result.Length -= 1;
            }
            else
            {
                result.Append(" None");
            }
            return result.ToString();
        }
    }
}
