using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawnerManager : MonoBehaviour
{
    [SerializeField]GameObject[]spwners;
    private Vector3[] SpwnerCoordinates;
    // Start is called before the first frame update
    void Start()
    {
        SpwnerCoordinates = new Vector3[4];
        SpwnerCoordinates[0] = new Vector3(373, 16, 233);
        SpwnerCoordinates[1] = new Vector3(351, 15, 226);
        SpwnerCoordinates[2] = new Vector3(373, 15, 184);
        SpwnerCoordinates[3] = new Vector3(318, 15, 172);
        InvokeRepeating("SpawnSpawners", 0, 0.5f);
;
    }
    void SpawnSpawners()
    {
        int randomIndex = Random.Range(0, 3);
        Vector3 spawnerCoordinate = SpwnerCoordinates[randomIndex];
        for (int i = 0; i < spwners.Length; i++)
        {
            spwners[i].transform.position = spawnerCoordinate;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
