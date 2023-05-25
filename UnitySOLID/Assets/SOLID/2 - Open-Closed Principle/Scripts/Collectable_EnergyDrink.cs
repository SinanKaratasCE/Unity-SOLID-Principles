using UnityEngine;

namespace SOLID.OpenClosed
{
    public class Collectable_EnergyDrink : MonoBehaviour, ICollectable
    {
        public void OnCollectableCollided()
        {
            Debug.Log($"Energy drink will regenerate your health and give you speed");
        }
    }
}