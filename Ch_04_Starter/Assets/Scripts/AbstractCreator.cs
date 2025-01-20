using UnityEngine;

public abstract class AbstractCreator {
    public GameObject spawner { get; protected set; }
    public GameObject model { get; protected set; }

    public AbstractCreator(GameObject model) {
        spawner = new GameObject();
        this.model = model;
    }
    public abstract IItem Create();

    // Alternative: For generating a default
    // public virtual IItem Create() { return new Pebble(); }

    // Alternative" For added abstraction (mo defaults)
    // protected abstract IItem Create();
    // public IItem GetInstance() { return this.Create(); }
}

public class PebbleFactory: AbstractCreator {
    public PebbleFactory(GameObject prefab) : base(prefab) {
        spawner.name = "Pebble Factory";
    }
    public override IItem Create() {
        // return new Pebble();

        GameObject pebble = GameObject.Instantiate(model);
        pebble.AddComponent<Pebble>();
        pebble.transform.position = new Vector3(-2.2f, 0.3f, -7f);
        pebble.transform.SetParent(spawner.transform);

        return pebble.GetComponent<Pebble>();
    }
}

public class CursedKnifeFactory: AbstractCreator {
    public CursedKnifeFactory(GameObject prefab) : base(prefab) {
        spawner.name = "Cursed Knife Factory";
    }

    public override IItem Create() {
        // return new CursedKnife();

        GameObject cursedKnife = GameObject.Instantiate(model);
        cursedKnife.AddComponent<CursedKnife>();
        cursedKnife.transform.position = new Vector3(-0.6f, 0.3f, -7.6f);
        cursedKnife.transform.SetParent(spawner.transform);

        return cursedKnife.GetComponent<CursedKnife>();
    }
}

public class PotionFactory: AbstractCreator {
    public PotionFactory(GameObject prefab) : base(prefab) {
        spawner.name = "Potion Factory";
    }

    public override IItem Create() {
        // return new Potion();

        GameObject potion = GameObject.Instantiate(model);
        potion.AddComponent<Potion>();
        potion.transform.position = new Vector3(-0.6f, 0.3f, -7f);
        potion.transform.SetParent(spawner.transform);

        return potion.GetComponent<Potion>();
    }
}


