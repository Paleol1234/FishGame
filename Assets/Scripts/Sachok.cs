using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sachok : MonoBehaviour
{
    public bool IsShow = false;
    
    bool fishOnHook = false;
    public GameObject fishItem;

    // Start is called before the first frame update
    void Start()
    {
        hook.fishToached += CheckHook;
        gameObject.SetActive(false);
    }
    void CheckHook(GameObject item)
    {
        print("fish in the sachok");
        fishOnHook = true;
        fishItem = item;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            IsShow = !IsShow;
            gameObject.SetActive(true);
            if (fishOnHook)
            {
                print(fishItem);
            }
        }
    }
}
