using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject[] inventory;
    [SerializeField] GameObject udochkaPrefab;
    public enum IdItem
    {
        UDOCHKA = 1,
        SACHOK = 2,
        PRIKORMKA = 3
    }
    // Start is called before the first frame update
    void Start()
    {
        inventory = new GameObject[10];
    }

    // Update is called once per frame          
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AddInventory(IdItem.UDOCHKA);
        }
    }
    private GameObject AddUdochkaToInventory()
    {

        GameObject udochka = Instantiate(udochkaPrefab,transform.position, Quaternion.identity);
        udochka.transform.parent = transform;
        return udochka;
    }
    public void AddInventory(IdItem idItem)
    {
        
        foreach(GameObject inventoryItem in inventory)
        {   
            if(inventoryItem && inventoryItem.CompareTag("Udochka")) { print("break"); break; }
            if (inventoryItem == null)
            {
                if (idItem == IdItem.UDOCHKA)
                {
                    inventory[0] = AddUdochkaToInventory();
                }
                break;
            }  
        }
    }
}
