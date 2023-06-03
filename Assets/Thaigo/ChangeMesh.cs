using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GD3D
{
    public class ChangeMesh : MonoBehaviour
    {
        public Mesh meshCube;
        public Mesh ballMesh;
        public Mesh triangle;
        public GameObject playerMesh;        


        public Collider col1;
        public Collider col2;
        public Collider col3;

        public bool isNotCube;
        // Update is called once per frame

        private void Start()
        {
            playerMesh.GetComponent<MeshFilter>().mesh = meshCube;
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                isNotCube = false;
                playerMesh.GetComponent<MeshFilter>().mesh = meshCube;
                col2.enabled = false;
                col1.enabled = true;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                isNotCube = true;
                playerMesh.GetComponent<MeshFilter>().mesh = ballMesh;
                col1.enabled = false;
                col2.enabled = true;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                isNotCube = true;
                playerMesh.GetComponent<MeshFilter>().mesh = triangle;
            }
            if (!isNotCube)
            {
                playerMesh.GetComponent<MeshFilter>().mesh = meshCube;
                col2.enabled = false;
                col1.enabled = true;
            }
        }

        
    }
}
