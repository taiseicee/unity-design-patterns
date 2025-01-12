using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(
    fileName = "Game Manger",
    menuName = "ScriptableObjects/Game Manager"
)]

public class SOManager : ScriptableSingleton<SOManager> {
    public int score = 0;
    public int startingLevel = 1;

    public void StartGame() {
        Debug.Log("New game has started with SO Manager");
        SceneManager.LoadScene(startingLevel);
    }
    
}
