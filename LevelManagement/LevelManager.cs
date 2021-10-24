using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class LevelManager : MonoBehaviour
    {
        public void GotoLevel(int scene)
        {
            SceneManager.LoadScene(scene);
        }

        public void NextLevel()
        {
            if(SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCount)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void PreviousLevel()
        {
            if (SceneManager.GetActiveScene().buildIndex - 1 > -1)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

        public void ResetLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}