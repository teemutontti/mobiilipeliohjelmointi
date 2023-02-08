using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer2D
{
    public class CameraMover : MonoBehaviour
    {
        [SerializeField]
        private GameObject player;
        [SerializeField]
        private Vector2 positionOffset = new Vector2(0,0);
        private Camera cam;

        [SerializeField]
        private float cameraZoom;
        private float cameraPosZ;

        private void Awake()
        {
            cam = GetComponent<Camera>();
        }
        void Start()
        {
            cameraPosZ = -12;
            this.transform.position = new Vector3(player.transform.position.x + positionOffset.x, player.transform.position.y + positionOffset.y, cameraPosZ);
        }

        // Update is called once per frame
        void Update()
        {
            this.transform.position = new Vector3(player.transform.position.x + positionOffset.x, player.transform.position.y + positionOffset.y, cameraPosZ);
            cam.orthographicSize = cameraZoom;
        }
    }
}

