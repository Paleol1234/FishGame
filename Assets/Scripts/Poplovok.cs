using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poplovok : MonoBehaviour
{
    GameObject indicator = null;
    // Start is called before the first frame update
    void Start()
    {
        indicator = GameObject.Find("indicator");
        gameObject.SetActive(true);

        hook.fishToached += StartIndicator;
        hook.fishOutside += StopIndicator;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void StartIndicator(GameObject item)
    {
        StartCoroutine(Blink()); 
    }
    void StopIndicator(GameObject item)
    {
        indicator.SetActive(false);
        StopCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        for (int i = 1; i< 6;i++)
        {
            indicator.SetActive(!indicator.activeSelf);
            yield return new WaitForSeconds(1);
        }
    }
}
