using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFish : MonoBehaviour
{
    [SerializeField] GameObject fishPrafab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FishCreator", 1, 10);
    }
    public void FishCreator()
    {
        GameObject fishScore = Instantiate(fishPrafab);
        int rndX = Random.Range(326, 398);
        int rndZ = Random.Range(108, 194);
        float rndY = Random.Range(15,16.5f);

        fishScore.transform.position = new Vector3(rndX, rndY, rndZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
