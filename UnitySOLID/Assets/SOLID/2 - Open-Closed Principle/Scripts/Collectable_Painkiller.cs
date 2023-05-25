using UnityEngine;

namespace SOLID.OpenClosed
{
    public class Collectable_Painkiller : MonoBehaviour, ICollectable
    {
        public void OnCollectableCollided()
        {
            Debug.Log($"Pain killer will heal your life");
        }
    }
}