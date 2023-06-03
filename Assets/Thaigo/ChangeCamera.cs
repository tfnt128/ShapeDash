using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GD3D
{
    public class ChangeCamera : MonoBehaviour
    {
        public CameraSwap camera;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("camera"))
            {
                StartCoroutine(camera.transtionCam());
            }
        }
    }
}
