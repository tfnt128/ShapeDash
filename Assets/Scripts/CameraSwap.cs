using System.Collections;
using UnityEngine;

namespace GD3D
{
    public class CameraSwap : MonoBehaviour
    {
        public bool is3D;
        [SerializeField] private GameObject PerspCamera;
        [SerializeField] private GameObject OrtoCamera;
        [SerializeField] private Animator transition;
        public IEnumerator transtionCam()
        {
            is3D = !is3D;
            transition.SetTrigger("Battle");
            yield return new WaitForSeconds(.1f);
            
            if (is3D)
            {               
                OrtoCamera.SetActive(false);
                PerspCamera.SetActive(true);
            }
            else
            {
                PerspCamera.SetActive(false);
                OrtoCamera.SetActive(true);
            }
            transition.SetTrigger("StarTranstion");

        }
    }
}
