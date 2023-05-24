using UnityEngine;

namespace SOLID.SingletonResponsibilitiy
{
    public class PlayerAudio : MonoBehaviour
    {
        #region Private Fields

        private AudioSource _hitSfx;
        #endregion

        #region Unity Methods

        private void Start()
        {
            _hitSfx = GetComponent<AudioSource>();
        }

        private void OnTriggerEnter(Collider other)
        {
            _hitSfx.Play();
        }

        #endregion
    }
}