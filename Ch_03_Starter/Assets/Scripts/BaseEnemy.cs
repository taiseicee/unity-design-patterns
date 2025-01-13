using UnityEngine;

public interface ICopy {
    public ICopy Copy(Transform parent);
}

public abstract class BaseEnemy : MonoBehaviour, ICopy {
    [SerializeField] protected int damage;
    [SerializeField] protected string message;
    [SerializeField] protected string enemy_name;

    public void OnEnable() {
        Debug.LogFormat($"{message} - an {enemy_name} entered the arena.");
    }

    public virtual void Attack() {
        Debug.LogFormat($"{enemy_name} attacks for {damage} HP!");
    }

    public ICopy Copy(Transform parent) {
        BaseEnemy clone = Instantiate(this);

        Vector3 clonePosition = new(Random.Range(-7, 7), 0, Random.Range(-7, 7));

        clone.transform.SetParent(parent);
        clone.transform.localPosition = clonePosition;

        return clone;
    }
}