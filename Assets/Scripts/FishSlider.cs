using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FishSlider : MonoBehaviour
{
    public Slider slider;
    const int MAX_TIME = 15;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.maxValue = MAX_TIME;
        StartCoroutine("CatchFishTime");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CatchFishTime()
    {
        for(int i = 0; i < MAX_TIME; i++)
        {
            slider.value -= 1;
            yield return new WaitForSeconds(1);
        }
    }
}
