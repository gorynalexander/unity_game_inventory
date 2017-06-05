using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour {
    public List<Item> itemList = new List<Item>();
   

	void Start () {
        itemList.Add(new Item(0, "apple", true));
        itemList.Add(new Item(1, "Slingshot", false));
        itemList.Add(new Item(2, "Pistol", false));
        itemList.Add(new Item(3, "knife", false));
    }
    public Item getItemById(int id)
    {
        for (int i = 0; i < itemList.Count; i++)
        {
            if (itemList[i].Id == id)
            {
                return itemList[i];
            }
        }
        return null;
    }

}

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsStackable { get; set; }
    public Sprite ItemImage { get; set; }

    public Item(int Id, string Name, bool IsStackable) {
        this.Id = Id;
        this.Name = Name;
        this.IsStackable = IsStackable;
        this.ItemImage = Resources.Load<Sprite>(Name);
    }
    
    public Item()
    {
        this.Id = -1;
    }


}
