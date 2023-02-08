using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer2D 
{
    public interface IMover
    {
        /// <summary>
        /// Moves the GameObject in the game world.
        /// </summary>
        /// <param name="direction"> The direction of the movement.</param>
        void Move(Vector2 direction);

        /// <summary>
        /// Returns the speed of a gameobject.
        /// </summary>
        /// <returns> The speed of a GameObject</returns>
        float GetSpeed();
    }
}
