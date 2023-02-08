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
            // Luetaan käyttäjän hahmoa liikuttava syöte muuttujaan.
            moveInput = context.ReadValue<Vector2>();
            Debug.Log($"Syöte: {moveInput}");
        }

        public Vector2 GetMoveInput()
        {
            return moveInput;
        }
    }
}

