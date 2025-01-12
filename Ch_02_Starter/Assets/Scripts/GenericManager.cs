using UnityEngine;
using UnityEngine.SceneManagement;

public class GenericManager : Singleton<GenericManager> {
    public int score = 0;
    public int startingLevel = 1;

    public void StartGame() {
        Debug.Log("New game has started with Generic Manager");
        SceneManager.LoadScene(startingLevel);
    }
}
