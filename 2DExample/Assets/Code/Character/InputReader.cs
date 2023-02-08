using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Platformer2D
{
    public class InputReader : MonoBehaviour
    {
        private Vector2 moveInput;

        public void OnMove(InputAction.CallbackContext context)
        {
            // Luetaan k�ytt�j�n hahmoa liikuttava sy�te muuttujaan.
            moveInput = context.ReadValue<Vector2>();
            Debug.Log($"Sy�te: {moveInput}");
        }

        public Vector2 GetMoveInput()
        {
            return moveInput;
        }
    }
}

