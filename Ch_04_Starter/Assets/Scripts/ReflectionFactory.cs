using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Reflection;

public class ReflectionFactory {
    public GameObject spawner { get; protected set; }
    private Dictionary<string, Type> _items = new();
    public Dictionary<string, Type> items {
        get { return _items; }
    }

    public ReflectionFactory() {
        spawner = new GameObject();
        spawner.name = "Reflection Factory";

        Type[] itemTypes = Assembly.GetAssembly(typeof(IItem)).GetTypes();

        IEnumerable<Type> filteredItems = itemTypes.Where(
            item => !item.IsInterface && typeof(IItem).IsAssignableFrom(item)
        );

        foreach (Type type in filteredItems) {
            _items.Add(type.Name, type);
        }

    }

    public IItem Create(string itemName, GameObject model, Vector3 position) {
        if (!_items.ContainsKey(itemName)) return null;

        Type type = _items[itemName];

        GameObject obj = GameObject.Instantiate(model);
        IItem item = obj.AddComponent(type) as IItem;

        obj.transform.position = position;
        obj.transform.SetParent(spawner.transform);

        return item;
    }
    
}
