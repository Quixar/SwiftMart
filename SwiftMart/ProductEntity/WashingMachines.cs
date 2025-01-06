using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.ProductEntity
{
    class WashingMachines : Product
    {
        public float MaximumLoad { get; set; }
        public float WaterConsumption { get; set; } // потребление воды за 1 цикл
        public string? EnergyEfficiency { get; set; } // класс энергопотребления
        public int MaximumSpinSpeed { get; set; }
    }
}
