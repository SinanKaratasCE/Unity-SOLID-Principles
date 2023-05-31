using UnityEngine;

namespace SOLID.Dependency
{
    public class Switch : MonoBehaviour
    {
        private ISwitchable client;

        public void Toggle()
        {
            if (client.IsActive)
            {
                client.Deactivate();
            }
            else
            {
                client.Activate();
            }
        }
    }
}