using UnityEngine;

namespace SOLID.SingletonResponsibilitiy
{
    [RequireComponent(typeof(PlayerAudio),typeof(PlayerInput))]
    [RequireComponent(typeof(PlayerMovement),typeof(PlayerHealth))]
    public class Player : MonoBehaviour
    {
        #region Private Fields
        [SerializeField] private PlayerAudio playerAudio;
        [SerializeField] private PlayerInput playerInput;
        [SerializeField] private PlayerMovement playerMovement;
        [SerializeField] private PlayerHealth playerHealth;
        #endregion

        #region Unity Methods

        private void Start()
        {
            playerAudio = GetComponent<PlayerAudio>();
            playerInput = GetComponent<PlayerInput>();
            playerMovement = GetComponent<PlayerMovement>();
            playerHealth = GetComponent<PlayerHealth>();
        }
        #endregion
    }
}