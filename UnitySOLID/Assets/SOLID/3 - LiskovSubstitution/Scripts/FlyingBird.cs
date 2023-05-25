using UnityEngine;

namespace SOLID.LiskovSubstitution
{
    public class FlyingBird : IMovable, IFlightable
    {
        private float moveSpeed = 100f;

        #region Public Fields

        public string Name;

        public float MoveSpeed
        {
            get => moveSpeed;
            set => moveSpeed = value;
        }

        public void Move()
        {
        }

        public void Fly()
        {
        }

        #endregion
    }
}