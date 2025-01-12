using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {
    public Text score;

    private void Start() {
        // score.text += Manager.Instance.score;
        // score.text += GenericManager.Instance.score;
        score.text += SOManager.Instance.score;
    }

    private void Update() {
        // score.text = $"Score: {Manager.Instance.score}";
        // score.text = $"Score: {GenericManager.Instance.score}";
        score.text = $"Score: {SOManager.Instance.score}";
    }
}