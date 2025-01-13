using UnityEngine;

public class ComponentSpawner : MonoBehaviour {
    [SerializeField]
    private Clone _ogrePrefab;
    [SerializeField]
    private Clone _ashKnightPrefab;
    private Factory<Clone> _factory = new();
    
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
                    clone = _factory["Ogre"].Copy<Ogre>();
                    break;
                case 2:
                    clone = _factory["Knight"].Copy<AshKnight>();
                    break; 
            }

            if (clone) clone.Attack();
        }
    }
}
