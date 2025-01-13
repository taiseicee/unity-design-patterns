using UnityEngine;

public class PrefabSpawner : MonoBehaviour {
    [SerializeField]
    private BaseEnemy _ogrePrefab;
    [SerializeField]
    private BaseEnemy _ashKnightPrefab;
    private Factory<ICopy> _factory = new();


    private void Awake() {
        _factory["Ogre"] = _ogrePrefab;
        _factory["Knight"] = _ashKnightPrefab;
    }

    private void Start() {
        for (int i = 0; i < 10; i++) {
            BaseEnemy clone = null;
            int random = Random.Range(1, 3);

            switch (random) {
                case 1:
                    clone = (BaseEnemy)_factory["Ogre"].Copy(transform);
                    break;
                case 2:
                    clone = (BaseEnemy)_factory["Knight"].Copy(transform);
                    break; 
            }

            if (clone) clone.Attack();
        }
    }
}
