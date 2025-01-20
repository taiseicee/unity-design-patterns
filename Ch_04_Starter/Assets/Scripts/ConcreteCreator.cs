using System.Collections.Generic;
using UnityEngine;

public class ConcreteCreator {
    public virtual IItem NormalItem() {
        // return new Pebble();

        GameObject pebble = GameObject.Instantiate(pebbleModel);
        IItem item = pebble.AddComponent<Pebble>();

        pebble.transform.position = new Vector3(-2.2f, 0.3f, -7f);
        pebble.transform.SetParent(spawner.transform);
        _items.Add(item);

        return pebble.GetComponent<Pebble>();
    }

    public virtual IItem RareItem() {
        // return new CursedKnife();

        GameObject cursedKnife = GameObject.Instantiate(knifeModel);
        IItem item = cursedKnife.AddComponent<CursedKnife>();

        cursedKnife.transform.position = new Vector3(-0.6f, 0.3f, -7.6f);
        cursedKnife.transform.SetParent(spawner.transform);
        _items.Add(item);

        return cursedKnife.GetComponent<CursedKnife>();
    }

    public virtual IItem HealingItem() {
        // return new Potion();

        GameObject potion = GameObject.Instantiate(potionModel);
        IItem item = potion.AddComponent<Potion>();

        potion.transform.position = new Vector3(0.6f, 0.3f, -7f);
        potion.transform.SetParent(spawner.transform);
        _items.Add(item);

        return potion.GetComponent<Potion>();
    }

    public List<IItem> CreateInventory() {
        return new List<IItem>() {
            NormalItem(),
            RareItem(),
            HealingItem()
        };
    }

    // With GameObjects

    public GameObject spawner { get; protected set; }

    public GameObject pebbleModel { get; protected set; }
    public GameObject knifeModel { get; protected set; }
    public GameObject potionModel { get; protected set; }

    protected List<IItem> _items = new();
    public List<IItem> items { get { return _items; } }

    public ConcreteCreator() {
        spawner = new GameObject();
        spawner.name = "Concrete Factory";

        pebbleModel = Resources.Load("Pebble") as GameObject;
        knifeModel = Resources.Load("Knife") as GameObject;
        potionModel = Resources.Load("Potion") as GameObject;

        CreateInventory();
    }
    
}

public class HealingFactory: ConcreteCreator {
    public override IItem NormalItem() {
        return new Potion();
    }

    public override IItem RareItem() {
        return new Potion();
    }

}
