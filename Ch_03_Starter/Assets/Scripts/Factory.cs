using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Factory<T> {
    private Dictionary<string, T> objects = new();

    public T this[string key] {
        get { return GetObject(key); }
        set { SetObject(key, value); }
    }

    private T GetObject(string key) {
        if (objects.ContainsKey(key)) return objects[key];

        throw new KeyNotFoundException($"Key not found: {key}");
    }

    private void SetObject(string key, T value) {
        if (objects.ContainsKey(key)) {
            objects[key] = value;
            return;
        }

        objects.Add(key, value);
    }
    
}
