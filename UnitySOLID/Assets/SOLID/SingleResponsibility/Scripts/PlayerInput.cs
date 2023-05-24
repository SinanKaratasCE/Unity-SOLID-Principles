using UnityEngine;

namespace SOLID.SingletonResponsibilitiy
{
    public class PlayerInput : MonoBehaviour
    {
        #region Private Fields
        [SerializeField] private string inputAxisName;
        #endregion

        #region Unity Methods

        private void Update()
        {
            float delta = Input.GetAxis(inputAxisName) * Time.deltaTime;
        }

        #endregion
    }
}