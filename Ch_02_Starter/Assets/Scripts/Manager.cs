using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {
    public static Manager Instance;
    public int score = 0;
    public int startingLevel = 1;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(Instance);
            Debug.Log($"Manager Instance {Instance.GetInstanceID()} Initialized");
        } else if (Instance != this) {
            Destroy(this.gameObject);
            Debug.Log($"Manager Instance {this.GetInstanceID()} Found; Deleting Self");
        }
    }

    public void StartGame() {
        Debug.Log("New game has started with Manager");
        SceneManager.LoadScene(startingLevel);
    }
}