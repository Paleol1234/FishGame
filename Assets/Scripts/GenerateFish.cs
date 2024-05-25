using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFish : MonoBehaviour
{
    [SerializeField] GameObject fishPrafab;
    List<GameObject> fishList = new List<GameObject>();
    GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FishCreator", 1, 10);
        //FishCreator();
        gameManager = FindObjectOfType<GameManager>();
    }
    public void FishCreator()
    {
        if(fishList.Count > 100)
        {
            return;
        }
        gameManager.AddFishScore();
        GameObject fishScore = Instantiate(fishPrafab);
        int rndX = Random.Range(326, 398);
        int rndZ = Random.Range(108, 194);
        float rndY = Random.Range(15,16.5f);

        fishScore.transform.position = new Vector3(rndX, rndY, rndZ);
        fishList.Add(fishScore);
        //fishScore.transform.position = new Vector3(364.2f, 15.9f, 159.72f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
