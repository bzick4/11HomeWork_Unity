using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    [SerializeField] private GameObject _panelWin, _panelLose;
    [SerializeField] private int numberScene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RestartScene"))
        {
            _panelLose.SetActive(true);
        }

        if (other.CompareTag("NextLevel"))
        {
            _panelWin.SetActive(true);
        }
    }

    public void Restart()
        {
            SceneManager.LoadScene(numberScene);
        }

        public void NextLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

