using UnityEngine;

namespace SOLID.LiskovSubstitution
{
    public class FlightlessBird : IMovable
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

        #endregion
    }
}