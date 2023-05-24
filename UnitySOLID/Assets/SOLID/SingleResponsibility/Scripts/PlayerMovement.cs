using UnityEngine;

namespace SOLID.SingletonResponsibilitiy
{
    public class PlayerMovement : MonoBehaviour
    {
        #region Private Fields

        [SerializeField] private float positionMultiplier;
        private float _yPosition;

        #endregion


        #region Unity Methods

        private void Update()
        {
            transform.position =
                new Vector3(transform.position.x, _yPosition * positionMultiplier, transform.position.z);
        }

        #endregion
    }
}