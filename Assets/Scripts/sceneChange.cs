using GD3D.Player;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GD3D
{
    public class sceneChange : MonoBehaviour
    {
        public GameObject canvasStart;
        public GameObject canvasCredits;

        public void credits()
        {
            canvasStart.SetActive(false);
            canvasCredits.SetActive(true);
        }
        public void back()
        {
            canvasCredits.SetActive(false);
            canvasStart.SetActive(true);
        }
        public void Star()
        {
            SceneManager.LoadScene("Level Template");
        }
    }
}
