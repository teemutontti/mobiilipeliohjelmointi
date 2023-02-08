using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer2D
{
    public class Mover : MonoBehaviour, IMover
    {
        [SerializeField]
        private float speed = 1;

        private Vector2 direction;

        private void Update()
        {
            Vector2 movement = direction * speed * Time.deltaTime;
            transform.Translate(movement);
        }

        public void Move(Vector2 direction)
        {
            this.direction = direction;
        }

        public float GetSpeed()
        {
            // Approximation of the speed. Make this more accurate if needed.
            if(direction.magnitude < 0.1f)
            {
                return 0;
            }
            return speed;
        }
    }
}

