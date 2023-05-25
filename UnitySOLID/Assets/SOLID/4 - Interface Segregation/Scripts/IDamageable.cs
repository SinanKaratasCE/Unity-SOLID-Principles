using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public interface IDamageable
    {
        public float Health { get; set; }
        public int Defense { get; set; }

        public void Die();
        public void TakeDamage();
    }
}