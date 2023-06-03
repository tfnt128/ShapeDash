using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GD3D
{
    public class TestMess : MonoBehaviour
    {
        public Mesh meshCube;
        public Mesh ballMesh;
        public Mesh triangle;
        public GameObject playerMesh;


        public BoxCollider col1;
        public Collider col2;

        public bool isNotCube;
        public bool isCil;

        public bool isQ;
        public bool isC;
        public bool isR;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                isNotCube = false;
                isCil = false;
                playerMesh.GetComponent<MeshFilter>().mesh = meshCube;

                isC = false;
                isR = false;
                isQ = true;
                ;            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                isCil = false;
                isNotCube = true;
                playerMesh.GetComponent<MeshFilter>().mesh = ballMesh;
                
                isQ = false;
                isR = false;
                isC = true;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {

                isCil = true;
                isNotCube = true;
                playerMesh.GetComponent<MeshFilter>().mesh = triangle;
                

                isC = false;
                isQ = false;
                isR = true;
                
            }
            if (!isNotCube)
            {
                playerMesh.GetComponent<MeshFilter>().mesh = meshCube;

                isC = false;
                isR = false;
                isQ = true;
            }
        }

        public void circle()
        {
            isCil = false;
            isNotCube = true;
            playerMesh.GetComponent<MeshFilter>().mesh = ballMesh;

            isQ = false;
            isR = false;
            isC = true;
        }
        public void cube()
        {
            isNotCube = false;
            isCil = false;
            playerMesh.GetComponent<MeshFilter>().mesh = meshCube;

            isC = false;
            isR = false;
            isQ = true;
        }
        public void cylinder()
        {
            isCil = true;
            isNotCube = true;
            playerMesh.GetComponent<MeshFilter>().mesh = triangle;


            isC = false;
            isQ = false;
            isR = true;
        }
    }
}
