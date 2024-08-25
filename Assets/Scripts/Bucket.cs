using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    private GameObject[] fishes;
    public string[] fishListName;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        fishes = new GameObject[4];
    }
    public string[] GetFishList()
    {
        fishListName = new string[fishes.Length];
        foreach(GameObject fish in fishes)
        {
            fishListName[index] = fish.GetComponent<Fish>().name;
            index++;
        }
        return fishListName;
    }
    public void ShowList()
    {
        for(int i = 0; i < fishes.Length; i++)
        {
            print(fishes[i]);
        }
    }
    
    public void Add(GameObject fish)
    {
        for(int i = 0; i < fishes.Length; i++)
        {
            if(fishes[i] == null)
            {
                fishes[i] = fish;
                fish.transform.position = transform.position;
                break;
            }
        }
        ShowList();
    }
    public void Remove()
    {

    }
}
