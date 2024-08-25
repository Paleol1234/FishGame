using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prikormka : MonoBehaviour
{
    [SerializeField] GameObject fishGenerator1;
    [SerializeField] GameObject fishGenerator2;
    [SerializeField] GameObject fishGenerator3;
    [SerializeField] GameObject fishGenerator4;
    public List<GameObject> fishList;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(chooseFish());
        fishList = FindObjectOfType<GenerateFish>().fishList;
    }
    IEnumerator chooseFish()
    {
        int randomInterval = Random.Range(5, 25);
        yield return new WaitForSeconds(randomInterval);
        print("start Corutine!!!!!");
        int randomIndex = Random.Range(0, fishList.Count);
        GameObject randomFish = fishList[randomIndex];
        //у выброной рыбы меняем направльение 
        fishList.Remove(randomFish);
        randomFish.GetComponent<Fish>().Stop();
        randomFish.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
