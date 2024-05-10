using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    [SerializeField] GameObject spherePrafab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateSphere", 1, 10);
    }
    public void GenerateSphere()
    {
        GameObject sphereScore = Instantiate(spherePrafab);
        int rndX = Random.Range(500,28 );
        
        sphereScore.transform.position = new Vector3(rndX, 1.84f, transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
