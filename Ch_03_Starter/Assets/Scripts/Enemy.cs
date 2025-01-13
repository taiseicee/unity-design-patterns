using UnityEngine;
using System;

public interface IPrototype {
    IPrototype ShallowClone();
    IPrototype DeepClone();
}

public class Enemy : IPrototype {
    public int damage;
    public string message;
    public string name;
    public Item item;

    public Enemy(int dmg, string msg, string name, Item item) {
        this.damage = dmg;
        this.message = msg;
        this.name = name;
        this.item = item;
    }

    public void Print() {
        Debug.LogFormat($"{message}! {name} has a {item.name} and can hit for {damage} HP.");
    }

    public IPrototype DeepClone() {
        Enemy newPrototype = (Enemy)ShallowClone();

        newPrototype.item = new Item(this.item.name);

        return newPrototype;
    }

    public IPrototype ShallowClone() {
        IPrototype newPrototype = null;

        try {
            newPrototype = (IPrototype)this.MemberwiseClone();
        } catch (Exception e) {
            Debug.LogError($"Error Cloning: {e}");
        }

        return newPrototype;
    }
}