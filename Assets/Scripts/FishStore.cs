using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishStore : MonoBehaviour
{
    [SerializeField] GameObject[] inventory;
    [SerializeField] GameObject closeButton;
    [SerializeField] GameObject windowStore;
    // Start is called before the first frame update
    void Start()
    {
        windowStore.SetActive(false);
    }

    public void SellUdochka()
    {
        print("udochka");
    }
    public void SellPrikormka()
    {
        print("Prikormka");
    }
    public void SellSachok()
    {
        print("Sachok");
    }
    public void OpenStore()
    {
        windowStore.SetActive(true);
    }
    public void CloseStore()
    {
        print("close");
        windowStore.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            //Time.timeScale = 0;
            print("Open Store");
            OpenStore();
        }
    }
}
