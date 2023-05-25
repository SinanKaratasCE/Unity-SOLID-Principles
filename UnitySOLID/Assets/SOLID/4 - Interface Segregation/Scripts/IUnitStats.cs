using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public interface IUnitStats
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Endurance { get; set; }
    }
}