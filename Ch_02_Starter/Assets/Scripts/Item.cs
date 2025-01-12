using UnityEngine;

public class Item : MonoBehaviour {
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            // Manager.Instance.score++;
            // GenericManager.Instance.score++;
            SOManager.Instance.score++;

            Destroy(this.gameObject);
            Debug.Log("Item collected!");
        }
    }
}