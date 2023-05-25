using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public class EnemyUnit : MonoBehaviour, IUnitStats, IDamageable, IRestorable, IMovable
    {
        public float Health { get; set; }
        public int Defense { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Endurance { get; set; }
        public float MoveSpeed { get; set; }
        public float Acceleration { get; set; }

        public void RestoreHealth()
        {
        }

        public void Die()
        {
        }

        public void TakeDamage()
        {
        }

        public void MoveForward()
        {
        }

        public void Reverse()
        {
        }

        public void TurnLeft()
        {
        }

        public void TurnRight()
        {
        }
    }
}