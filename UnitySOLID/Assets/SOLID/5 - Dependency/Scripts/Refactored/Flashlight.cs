using UnityEngine;

namespace SOLID.Dependency
{
    public class Flashlight : MonoBehaviour, ISwitchable
    {
        private bool isActive;

        #region Public Fields

        public bool IsActive => isActive;

        #endregion

        public void Activate()
        {
            isActive = true;
            Debug.Log("The flashlight is open.");
        }

        public void Deactivate()
        {
            isActive = false;
            Debug.Log("The flashlight is closed.");
        }
    }
}