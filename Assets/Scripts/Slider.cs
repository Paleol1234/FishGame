using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CatchFishTime");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CatchFishTime()
    {
        for(int i = 0; i < 10; i++)
        {
            print(i+1);
            yield return new WaitForSeconds(1);
        }
    }
}
