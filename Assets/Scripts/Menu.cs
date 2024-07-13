using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject[] items;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SellUdochka()
    {
        GameObject item = Instantiate(items[0]);
        item.transform.position = new Vector3 (0, 0, 0);
    }
    public void SellPrikormka()
    {
        GameObject item = Instantiate(items[1]);
        item.transform.position = new Vector3(0, 0, 0);
    }
    public void SellSachok()
    {
        GameObject item = Instantiate(items[2]);
        item.transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
