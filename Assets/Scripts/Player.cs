using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject[] inventory; 
    // Start is called before the first frame update
    void Start()
    {
        inventory = new GameObject[10];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddInventory(GameObject item)
    {
        bool hasFreeCell = false;
        foreach(GameObject inventoryItem in inventory)
        {
            if(inventoryItem == null)
            {
                hasFreeCell = true;
                break;
            }
            else
            {
                hasFreeCell = false;
            }
        }
        if (hasFreeCell)
        {
            inventory[inventory.Length - 1] = item;
        }
    }
}
