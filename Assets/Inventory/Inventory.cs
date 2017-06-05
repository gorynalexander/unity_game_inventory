using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {
    private ItemDatabase database;
    public GameObject[] slots;
    public GameObject itemImage;
    private int slotsCount = 10;
    List<Item> items = new List<Item>();
    

	// Use this for initialization
	void Start () {
        database = GetComponent<ItemDatabase>();
        for (int i = 0; i < slotsCount; i++)
        {
            items.Add(new Item());
        }
        //addToInventory(0);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "item")
        {

            if (col.gameObject.name[0] == '0')
            {
                addToInventory(0);
                Destroy(col.gameObject);
            }
            if (col.gameObject.name[0] == '3')
            {
                addToInventory(3);
                Destroy(col.gameObject);
            }

        }
    }
    void addToInventory(int id)
    {
        try
        {
            Item itemToAdd = database.getItemById(id);
            Debug.Log(itemToAdd.Name + itemToAdd.IsStackable);
            if (itemToAdd.IsStackable)
            {

            }
            for (int i = 0; i < slotsCount; i++)
            {
                if (items[i].Id == itemToAdd.Id)
                {
                    if (itemToAdd.IsStackable)
                    {
                        Debug.Log("HELLO FROM STACKABLE");
                        return;
                    }
                }
            }
            for (int i = 0; i < slotsCount; i++)
            { 
                if (items[i].Id == -1)
                {
                    items[i] = itemToAdd;
                    GameObject itemObject = Instantiate(itemImage);
                    itemObject.transform.SetParent(slots[i].transform);
                    itemObject.transform.localPosition = Vector3.zero;
                    itemObject.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);
                    Image image = itemObject.GetComponent<Image>();
                    image.sprite = itemToAdd.ItemImage;
                    break;
                }

            }
        }
        catch (Exception e)
        {
            Debug.Log("ITEM IS NOT EXIST");
        }


    }

}
