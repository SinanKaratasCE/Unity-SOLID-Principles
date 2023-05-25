using UnityEngine;

namespace SOLID.OpenClosed
{
    public class Collectable_Gun : MonoBehaviour, ICollectable
    {
        public void OnCollectableCollided()
        {
            Debug.Log($"Use Gun for killing long distance enemy");
        }
    }
}