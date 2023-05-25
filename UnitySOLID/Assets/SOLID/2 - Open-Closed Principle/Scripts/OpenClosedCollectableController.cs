using SOLID.OpenClosed;
using UnityEngine;

namespace OpenClosed
{
    public class OpenClosedCollectableController : MonoBehaviour
    {
        ICollectable _currentCollectable;

        public void Oncollided(GameObject collidedObj)
        {
            _currentCollectable = collidedObj.GetComponent<ICollectable>();
            _currentCollectable.OnCollectableCollided();
        }
    }
}