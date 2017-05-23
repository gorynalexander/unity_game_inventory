using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryController : MonoBehaviour {

    //public GameObject[] items;
    public GameObject[] cells;

    //public Sprite[] itemImages;
    //public bool[] isSlotOccupied;

    private bool isPressed = false;

    

	void Update () {
	    if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("space key was pressed");
            isPressedMethod(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("2 was pressed");
            isPressedMethod(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("3 was pressed");
            isPressedMethod(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log("3 was pressed");
            isPressedMethod(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Debug.Log("3 was pressed");
            isPressedMethod(4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Debug.Log("3 was pressed");
            isPressedMethod(5);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Debug.Log("3 was pressed");
            isPressedMethod(6);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            Debug.Log("3 was pressed");
            isPressedMethod(7);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            Debug.Log("3 was pressed");
            isPressedMethod(8);
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Debug.Log("3 was pressed");
            isPressedMethod(9);
        }
    }

    void isPressedMethod(int number)
    {
        foreach (GameObject cell in cells)
        {
            cell.GetComponent<SpriteRenderer>().color = Color.white;
        }

        cells[number].GetComponent<SpriteRenderer>().color = Color.blue;

    }

    /*
    public void addToInventory(GameObject gObject)
    {
       for (int i = 0; i < items.Length; i++)
        {
            if (!isSlotOccupied[i])
            {
                items[i].GetComponent<SpriteRenderer>().sprite = itemImages[i]; // будет равно gameObject name toInt32
            }
        }
    }
    */

}
