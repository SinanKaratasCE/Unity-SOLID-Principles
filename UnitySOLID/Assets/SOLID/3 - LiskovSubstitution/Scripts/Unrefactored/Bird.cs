using UnityEngine;

namespace SOLID.LiskovSubstitution
{
    public class Bird : MonoBehaviour
    {
        #region Public Fields

        public float speed = 10f;
        public string name;
        public Vector3 direction;
        public float flightSpeed;

        // Don't include these in the base class; use composition instead of inheritance.
        // We put the functionality instead into the ITurnable,IMovable and IFlightable interfaces.

        // The Flying Bird and Flightless Bird classes can then implement only what they need.

        #endregion


        #region Public Methods

        //    public void Move()
        //    {
        //     
        // }
        //    
        //    
        //    public void Fly()
        // {
        //     
        // }

        #endregion
    }
}