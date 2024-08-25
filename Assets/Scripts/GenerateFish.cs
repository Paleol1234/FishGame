using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFish : MonoBehaviour
{
    [SerializeField] Fish fishPrafab;
    [SerializeField] Fish tolstoPrefab;
    [SerializeField] Fish somPrefab;
    [SerializeField] Fish karasPrefab;


    public List<GameObject> fishList = new List<GameObject>();
    public Dictionary<string,Fish> fishDict = new Dictionary<string,Fish>();
    GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FishCreator", 1, 5);
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
        Fish fishScore;
        
        int number= Random.Range(1,4);
        if(number == 1)
        {
             fishScore = Instantiate(fishPrafab);
             fishDict.Add("Sardine", fishScore);
            fishScore.type = "Sardine";
        }
        else if(number == 2)
        {
             fishScore = Instantiate(tolstoPrefab);
            fishDict.Add("Tolstolobik", fishScore);
            fishScore.type = "Tolstolobik";
        }
        else if (number == 3)
        {
             fishScore = Instantiate(somPrefab);
            fishDict.Add("Som", fishScore);
            fishScore.type = "Som";
        }
        else
        {
             fishScore = Instantiate(karasPrefab);
            fishDict.Add("Karas", fishScore);
            fishScore.type = "Kasras";
        }



        int rndX = Random.Range(326, 398);
        int rndZ = Random.Range(108, 194);
        float rndY = Random.Range(15,16.5f);

        fishScore.transform.position = new Vector3(rndX, rndY, rndZ);
       
        //fishScore.transform.position = new Vector3(364.2f, 15.9f, 159.72f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
