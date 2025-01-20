using UnityEngine;

public class ParameterizedCreator {
    public virtual IItem Create(string itemName) {
        switch (itemName) {
            case "Normal":
                return new Pebble();
            case "Rare":
                return new CursedKnife();
            case "Healing":
                return new Potion();
            default:
                return null;
        }
    }
    
}
