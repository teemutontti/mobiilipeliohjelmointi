using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer2D
{
    public class PhysicsMover : MonoBehaviour, IMover
    {
        [SerializeField]
        private float speed = 1;

        private Vector2 direction;
        private Rigidbody2D rb2D;

        private void Awake()
        {
            rb2D = GetComponent<Rigidbody2D>();
            if(rb2D == null)
            {
                Debug.LogError($"{gameObject} is missing a component Rigidbody2D which is is dependant on!");
            }
        }

        private void FixedUpdate()
        {
            Vector2 movement = direction * speed * Time.fixedDeltaTime;
            rb2D.MovePosition(rb2D.position + movement);
        }

        public float GetSpeed()
        {
            if (direction.magnitude < 0.1f)
            {
                return 0;
            }
            return speed;
        }

        public void Move(Vector2 direction)
        {
            this.direction = direction;
        }
    }
}

