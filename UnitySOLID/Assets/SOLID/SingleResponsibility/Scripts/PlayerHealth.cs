using UnityEngine;

namespace SOLID.SingletonResponsibilitiy
{
    public class PlayerHealth : MonoBehaviour
    {
        #region Private Fields

        private float _health;

        #endregion

        #region Public Fields

        public float Health
        {
            get
            {
                if (_health < 0)
                    return 0;

                return _health;
            }

            set
            {
                if (Health < 0)
                {
                    Debug.Log($"Player is dead, cannot change health value");
                }
                else
                {
                    _health = value;
                }
            }
        }

        #endregion

    }
}