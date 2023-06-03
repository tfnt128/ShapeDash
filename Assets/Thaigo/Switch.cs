using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GD3D
{
    public class Switch : MonoBehaviour
    {
        public GameObject blackScreen;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if(blackScreen != null)
                {
                    Destroy(blackScreen.gameObject);
                }               
            }
        }
    }
}
