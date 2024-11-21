using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private SceneController _sceneController;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) // Enter key
        {
            // Optionally, fade out before loading the game
            _sceneController.LoadScene("Space Invaders");
        }
        else if (Input.GetKeyDown(KeyCode.Escape)) // Escape key
        {
            Application.Quit();
        }
    }
}
