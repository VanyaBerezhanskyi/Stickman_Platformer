using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    void Awake()
    {
        Messenger.AddListener(GameEvent.PLAYER_DEATH, RestartLevel);
        Messenger.AddListener(GameEvent.LEVEL_COMPLETE, OnLevelComplete);
        Messenger.AddListener(GameEvent.LEVEL_RESTART, RestartLevel);
    }

    void OnDestroy()
    {
        Messenger.RemoveListener(GameEvent.PLAYER_DEATH, RestartLevel);
        Messenger.RemoveListener(GameEvent.LEVEL_COMPLETE, OnLevelComplete);
        Messenger.RemoveListener(GameEvent.LEVEL_RESTART, RestartLevel);

    }

    private void RestartLevel()
    {
        SceneManager.LoadScene("Level1");

        Time.timeScale = 1.0f;
    }

    private void OnLevelComplete()
    {
        Time.timeScale = 0.0f;
    }
}
