using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PickUpScript : MonoBehaviour {

    public GameObject[] items;
    public Sprite[] itemImages;
    public bool[] isSlotOccupied;

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "item")
        {
            Debug.Log("PickUP it and destroy");
            addToInventory(col.gameObject);
            Destroy(col.gameObject);
        }
    }

    public void addToInventory(GameObject gObject)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (!isSlotOccupied[i])
            {
                isSlotOccupied[i] = true;
                items[i].GetComponent<Image>().sprite = itemImages[int.Parse(gObject.name)];
                items[i].GetComponent<Image>().enabled = true;
                //items[i].GetComponent<ImageN>().GetComponent<Item>().amount++;
                break;
            }
        }
    }
    
}
