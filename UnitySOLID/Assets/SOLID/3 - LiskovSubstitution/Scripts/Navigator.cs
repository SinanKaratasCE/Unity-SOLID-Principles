using UnityEngine;

namespace SOLID.LiskovSubstitution
{
    public class Navigator : MonoBehaviour
    {
        // This example violates Liskov Substitution Principle. We cannot substitute the subtype Penguin
        // for the type Bird here.  A Penguin cannot functionally fly:

        //public void Move(Bird bird)
        //{
        //    bird.Move();
        //    bird.Fly();
        //}

        // Instead, we can use these methods that do follow Liskov Substitution principle.
        // Enforce inheritance hierarchy based on software design, not on real-world analogies.

        public void MoveFlyingBird(FlyingBird flyingBird)
        {
            flyingBird.Move();
            flyingBird.Fly();
        }

        public void MoveFlightlessBird(FlightlessBird flightlessBird)
        {
            flightlessBird.Move();
        }
    }
}