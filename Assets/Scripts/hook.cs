using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hook : MonoBehaviour
{
    float Interval = 10;
    GameObject currentFish = null;
    public delegate void FishCallback(GameObject currentFish);
    public static FishCallback fishToached;
    public static FishCallback fishOutside;
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(Interval);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fish"))
        {
            currentFish=other.gameObject;
            fishToached(currentFish);
            //отключаем у рыбы движение
            currentFish.GetComponent<Fish>().Stop();
        }
        print("Colution");
        
    }
    private void OnTriggerExit(Collider other)
    {
      if (other.gameObject.CompareTag("Fish"))
        {
            currentFish = other.gameObject;
            fishOutside(currentFish);
        }  
    }
}
