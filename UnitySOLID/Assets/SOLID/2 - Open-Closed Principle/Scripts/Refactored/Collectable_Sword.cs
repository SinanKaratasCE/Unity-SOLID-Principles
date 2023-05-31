using UnityEngine;

namespace SOLID.OpenClosed
{
    public class Collectable_Sword : MonoBehaviour, ICollectable
    {
        public void OnCollectableCollided()
        {
            Debug.Log($"Use sword for slashing goblins");
        }
    }
}