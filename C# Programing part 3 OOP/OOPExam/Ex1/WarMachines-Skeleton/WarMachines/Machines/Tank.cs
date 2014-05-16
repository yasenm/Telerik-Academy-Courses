using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Tank : Machine, ITank
    {
        public Tank(string name, double attackPoints, double defensePoints) : base(name, attackPoints, defensePoints)
        {
            this.HealthPoints = 100;
            this.SetStartingValues();
        }

        private void SetStartingValues()
        {
            this.DefensePoints += 30;
            this.AttackPoints -= 40;
            this.DefenseMode = true;
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if (this.DefenseMode == true)
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
            else
            {
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("- {0}\n", this.Name));
            result.Append(String.Format(" *Type: {0}\n", this.GetType().Name));
            result.Append( base.ToString());
            result.Append(String.Format("\n *Defense: {0}\n", this.DefenseMode ? "ON" : "OFF"));
            return result.ToString();
        }
    }
}
