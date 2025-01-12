using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {
    [SerializeField]
    private Button _startButton;

    private void Start() {
        // _startButton.onClick.AddListener(Manager.Instance.StartGame);
        // _startButton.onClick.AddListener(GenericManager.Instance.StartGame);
        _startButton.onClick.AddListener(SOManager.Instance.StartGame);
    }
}
