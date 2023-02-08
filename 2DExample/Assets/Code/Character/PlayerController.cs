using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer2D
{
    public class PlayerController : MonoBehaviour
    {
        private const string AnimatorX = "Look X";
        private const string AnimatorY = "Look Y";
        private const string AnimatorSpeed = "Speed";

        private InputReader inputReader;
        private IMover mover;
        private Animator animator;

        private void Awake()
        {
            inputReader = GetComponent<InputReader>();
            mover = GetComponent<IMover>();
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            Vector2 movement = inputReader.GetMoveInput();
            mover.Move(movement);
            UpdateAnimator(movement);

        }

        private void UpdateAnimator(Vector2 movement)
        {
            animator.SetFloat(AnimatorX, movement.x);
            animator.SetFloat(AnimatorY, movement.y);
            animator.SetFloat(AnimatorSpeed, this.mover.GetSpeed());
        }
    }
}

