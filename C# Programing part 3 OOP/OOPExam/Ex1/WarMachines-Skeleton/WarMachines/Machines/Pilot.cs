using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Pilot : IPilot
    {
        public Pilot(string name)
        {
            this.Name = name;
        }

        public string Name { get; protected set; }

        public IList<IMachine> machines = new List<IMachine>();

        public void AddMachine(IMachine machine)
        {
            if (machine != null)
            {
                machines.Add(machine);
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        private List<IMachine> SortMachines() 
        {
            var sortedMachines = machines.OrderBy(machine => machine.HealthPoints).ThenBy(machine => machine.Name).ToList();
            return sortedMachines;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            if (this.machines.Count == 1)
            {
                result.Append(String.Format("{0} - {1}\n", this.Name, "1 machine"));
            }
            else
            {
                result.Append(String.Format("{0} - {1}", this.Name, this.machines.Count > 0 ? this.machines.Count + " machines\n" : "no machines"));
            }

            if (this.machines.Count > 0)
            {
                foreach (var machine in SortMachines())
                {
                    result.Append(machine.ToString());
                }
            }

            return result.ToString();
        }

    }
}
