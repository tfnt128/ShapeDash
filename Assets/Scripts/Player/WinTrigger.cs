using GD3D.Player;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GD3D
{
    public class WinTrigger : MonoBehaviour
    {
        public GameObject canvasWin;
        public GameObject canvasShape;
        public PlayerMain player;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                player.enabled = true;
                canvasShape.SetActive(false);
                canvasWin.SetActive(true);                
            }
        }

        public void Quit()
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
