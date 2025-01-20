using UnityEngine;

public interface IItem {
    public void Equip();
}

public class Pebble: MonoBehaviour, IItem {
    public void Equip() {
        Debug.Log("You skipped the pebble at a nearby lake.");
    }
}

public class CursedKnife: MonoBehaviour, IItem {
    public void Equip() {
        Player player = GameObject.FindAnyObjectByType<Player>();
        player.SetColor(Color.magenta);
        Debug.Log("Woops, you're cursed....");
    }
}

public class Potion: MonoBehaviour, IItem {
    public void Equip() {
        Player player = GameObject.FindAnyObjectByType<Player>();
        player.SetColor(Color.green);

        Manager manager = GameObject.FindAnyObjectByType<Manager>();
        manager.HP += 5;
        manager.Boost++;

        Debug.Log("Potion healed you for 5 HP~");
    }
}
