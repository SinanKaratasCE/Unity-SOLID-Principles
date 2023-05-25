using UnityEngine;

namespace SOLID.LiskovSubstitution
{
    public interface IMovable
    {
        public float MoveSpeed { get; set; }

        public void Move();
    }
}