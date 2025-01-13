using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSpawner : MonoBehaviour {
    // private void Start() {
    //     Enemy ogre = new Enemy(10, "RAWR", "Ogre", new Item("Poison Dart"));
    //     Debug.Log("Initial");
    //     ogre.Print();

    //     IPrototype clonedPrototype = ogre.DeepClone();
    //     if (clonedPrototype is Enemy clonedEnemy) {
    //         clonedEnemy.Print();

    //         Debug.Log("Updated");
    //         ogre.name = "Monstrous Ogre";
    //         ogre.damage = 30;
    //         ogre.item.name = "Potion";

    //         ogre.Print();
    //         clonedEnemy.Print();
    //     } else {
    //         Debug.Log("Failed to clone ogre. Cloned object is not an enemy");
    //     }
    // }

    private void Start() {
        Factory<IPrototype> factory = new();

        factory["Ogre"] = new Enemy(10, "RAWR", "Ogre", new Item("Poison Dart"));
        factory["Knight"] = new Enemy(10, "To Arms!", "Ash Knight", new Item("Sword"));

        IPrototype ogrePrototype = (Enemy)factory["Ogre"].DeepClone();
        IPrototype knightPrototype = (Enemy)factory["Knight"].DeepClone();

        if (ogrePrototype is Enemy ogreEnemy) ogreEnemy.Print();
        if (knightPrototype is Enemy knightEnemy) knightEnemy.Print();

    }
}