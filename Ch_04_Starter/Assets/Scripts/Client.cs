using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour {
    public ItemButton buttonPrefab;

    public GameObject pebbleModel;
    public GameObject cursedKnifeModel;
    public GameObject potionModel;

    private void Start() {
        // Abstract Creator
        // List<AbstractCreator> factories = new() {
        //     new PebbleFactory(),
        //     new CursedKnifeFactory(),
        //     new PotionFactory()
        // };

        // foreach (AbstractCreator factory in factories) {
        //     ItemButton button = Instantiate(buttonPrefab);

        //     IItem item = factory.Create();

        //     button.Configure(item);
        //     button.transform.SetParent(this.transform);
        // }

        // Concrete Creator
        // HealingFactory creator = new();
        // List<IItem> items = creator.CreateInventory();

        // foreach (IItem item in items) {
        //     ItemButton button = Instantiate(buttonPrefab);

        //     button.Configure(item);
        //     button.transform.SetParent(this.transform);
        // }

        // Parameterized Creator
        // ParameterizedCreator creator = new();
        // List<IItem> items = new(){
        //     creator.Create("Normal"),
        //     creator.Create("Rare"),
        //     creator.Create("Healing")
        // };

        // foreach (IItem item in items) {
        //     ItemButton button = Instantiate(buttonPrefab);

        //     button.Configure(item);
        //     button.transform.SetParent(this.transform);
        // }

        // Reflection Factory
        // ReflectionFactory itemFactory = new();

        // List<IItem> items = new() {
        //     itemFactory.Create("Pebble"),
        //     itemFactory.Create("CursedKnife"),
        //     itemFactory.Create("Potion")
        // };

        // foreach (IItem item in items) {
        //     ItemButton button = Instantiate(buttonPrefab);

        //     button.Configure(item);
        //     button.transform.SetParent(this.transform);
        // }

        // Abstract Creator with Object
        // List<AbstractCreator> factories = new() {
        //     new PebbleFactory(pebbleModel),
        //     new CursedKnifeFactory(cursedKnifeModel),
        //     new PotionFactory(potionModel)
        // };

        // foreach (AbstractCreator factory in factories) {
        //     ItemButton button = Instantiate(buttonPrefab);

        //     IItem item = factory.Create();
        //     button.Configure(item);
        //     button.transform.SetParent(this.transform);
        // }

        // Concrete Creator with Object
        // ConcreteCreator creator = new();

        // foreach (IItem item in creator.items) {
        //     ItemButton button = Instantiate(buttonPrefab);

        //     button.Configure(item);
        //     button.transform.SetParent(this.transform);
        // }

        // Reflection Factory with Object
        List<Vector3> pos = new() {
            new Vector3(-2.2f, 0.3f, -7f),
            new Vector3(-0.6f, 0.3f, -7.6f),
            new Vector3(0.6f, 0.3f, -7f),
        };

        ReflectionFactory itemFactory = new();

        List<IItem> items = new() {
            itemFactory.Create("Pebble", pebbleModel, pos[0]),
            itemFactory.Create("CursedKnife", cursedKnifeModel, pos[1]),
            itemFactory.Create("Potion", potionModel, pos[2])
        };

        foreach (IItem item in items) {
            ItemButton button = Instantiate(buttonPrefab);

            button.Configure(item);
            button.transform.SetParent(this.transform);
        }
    }
}