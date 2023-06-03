using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GD3D
{
    public class RotateMesh : MonoBehaviour
    {

        public GameObject mesh;
        public GameObject canvasButons;
        public bool canRot;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                canRot = true;
                
                canvasButons.SetActive(true);
            }
        }

        private void Update()
        {
            if (canRot)
            {
                Vector3 currentRotation = mesh.transform.rotation.eulerAngles;
                mesh.transform.rotation = Quaternion.Euler(currentRotation.x, currentRotation.y, 0f);
            }
        }
    }
}
