using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.ProductEntity
{
    class Refrigerators : Product
    {
        public int TotalVolume { get; set; } // общий объем
        public string? Type { get; set; } // однокамерный, две камеры
        public string? EnergyEfficiency { get; set; } // класс энергопотребления
        public float RefrigeratorHeight { get; set; }
        public float RefrigeratorWidth { get; set; }
        public float RefrigeratorDepth { get; set; } // глубина
        public bool HasFreezer { get; set; }
    }
}
