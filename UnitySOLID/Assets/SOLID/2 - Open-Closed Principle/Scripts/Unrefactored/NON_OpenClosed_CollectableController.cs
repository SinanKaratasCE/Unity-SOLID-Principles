using UnityEngine;

namespace SOLID.OpenClosed
{
    public enum CollectableType
    {
        Sword,
        Gun,
        Painkiller,
        EnergyDrink
    };

    public class NON_OpenClosed_CollectableController : MonoBehaviour
    {
        #region Public Fields

        public CollectableType currentCollidedObjectType = CollectableType.Gun;

        #endregion


        #region Private Methods

        private void Oncollided(CollectableType collidedObjectType)
        {
            currentCollidedObjectType = collidedObjectType;

            switch (currentCollidedObjectType)
            {
                case CollectableType.Sword:
                    Debug.Log($"Use sword for slashing goblins");
                    break;
                case CollectableType.Gun:
                    Debug.Log($"Use Gun for killing long distance enemy");
                    break;
                case CollectableType.Painkiller:
                    Debug.Log($"Pain killer will heal your life");
                    break;
                case CollectableType.EnergyDrink:
                    Debug.Log($"Energy drink will regenerate your health and give you speed");
                    break;
            }
        }

        #endregion
    }
}