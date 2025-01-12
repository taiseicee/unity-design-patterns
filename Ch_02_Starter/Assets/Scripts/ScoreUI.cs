using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {
    public Text score;

    private void Start() {
        score.text += GenericManager.Instance.score;
    }

    private void Update() {
        score.text = $"Score: {GenericManager.Instance.score}";
    }
}