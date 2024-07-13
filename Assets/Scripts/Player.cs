using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject[] inventory;
    [SerializeField] GameObject udochkaPrefab;
    [SerializeField] Transform SpawnPoint;
    [SerializeField] Bucket bucket;
    [SerializeField]Sachok sachok;
    public enum IdItem
    {
        UDOCHKA = 1,
        SACHOK = 2,
        PRIKORMKA = 3
    }
    private int inventoryIndex = default; 
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
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            AddInventory(IdItem.PRIKORMKA);
        }
        if (Input.GetMouseButton(0))
        {
           // bucket.Add(sachok.fishItem);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            foreach (string name in bucket.GetFishList())
                if(name != null)
                    print(name);
        }
    }
    private GameObject AddUdochkaToInventory()
    {

        GameObject udochka = Instantiate(udochkaPrefab);
        udochka.transform.parent = transform;
        udochka.transform.position = SpawnPoint.position;
        udochka.transform.rotation = Quaternion.identity;
        return udochka;
    }
    public void AddInventory(IdItem idItem)
    {
        
        foreach(GameObject inventoryItem in inventory)
        {   
            if(inventoryItem && inventoryItem.CompareTag("Udochka")) break;
            if (inventoryItem == null)
            {
                if (idItem == IdItem.UDOCHKA)
                {
                    inventory[inventoryIndex] = AddUdochkaToInventory();
                    inventoryIndex += 1;
                }
                break;
            }  
        }
    }
}
