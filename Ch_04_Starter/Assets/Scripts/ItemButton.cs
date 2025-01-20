using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour {
    public void Configure(IItem item) {
       this.gameObject.name = $"{item.GetType().Name} (UI)";

       Button button = GetComponent<Button>();
       button.onClick.AddListener(item.Equip);

       Text text = GetComponentInChildren<Text>();
       text.text = $"{item.GetType().Name} (Item)";
    }
}