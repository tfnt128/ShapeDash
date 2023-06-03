using GD3D.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GD3D
{
    public class Walls : MonoBehaviour
    {
        public bool isQ;
        public bool isC;
        public bool isR;
        public TestMess mesh;

        public PlayerDeath death;
        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if(mesh.isC && !isC)
                {
                    death.Die();
                }
                if(mesh.isQ && !isQ)
                {
                    death.Die();
                }
                if(mesh.isR && !isR)
                {
                    death.Die();
                }
            }
        }
    }
}
