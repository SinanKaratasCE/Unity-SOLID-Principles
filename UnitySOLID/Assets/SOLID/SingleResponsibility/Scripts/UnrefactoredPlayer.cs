using UnityEngine;

namespace SOLID.SingletonResponsibilitiy
{
    public class UnrefactoredPlayer : MonoBehaviour
    {
        [SerializeField] private string _inputAxisName;
        [SerializeField] private float _positionMultiplier;

        private float _yPosition;
        private AudioSource _hitSfx;
        private float _health;
        
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

        private void Start()
        {
            _hitSfx = GetComponent<AudioSource>();
        }

        private void Update()
        {
            float delta = Input.GetAxis(_inputAxisName) * Time.deltaTime;

            _yPosition = Mathf.Clamp(_yPosition + delta, -1, 1);

            transform.position = new Vector3(transform.position.x, _yPosition * _positionMultiplier, transform.position.z);
        }

        private void OnTriggerEnter(Collider other)
        {
            _hitSfx.Play();
        }
        
        
    }
}