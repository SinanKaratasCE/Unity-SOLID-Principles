using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public class Turret : MonoBehaviour, IDamageable, IExplodable
    {
        public float Health { get; set; }
        public int Defense { get; set; }
        public float Mass { get; set; }
        public float ExplosiveForce { get; set; }
        public float FuseDelay { get; set; }
        public float Timeout { get; set; }

        public void Die()
        {
        }

        public void TakeDamage()
        {
        }


        public void Explode()
        {
        }
    }
}