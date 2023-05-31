using UnityEngine;

namespace SOLID.Dependency
{
    public class DependedSwitch : MonoBehaviour
    {
        public UnrefactoredChest chest;
        public UnrefactoredFlashlight flashlight;
        public bool IsActivated;

        public void ActivateChest()
        {
            if (IsActivated)
            {
                IsActivated = false;
                chest.Close();
            }
            else
            {
                IsActivated = true;
                chest.Open();
            }
        }

        public void ActivateFlashlight()
        {
            if (IsActivated)
            {
                IsActivated = false;
                flashlight.Close();
            }
            else
            {
                IsActivated = true;
                flashlight.Open();
            }
        }
    }
}