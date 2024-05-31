using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int FishScore = 0;
    public Text text;
    public Text fishCount;
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void AddScore()
    {
        score += 1;
        text.text = $"Score: {score.ToString()}";
        print(score);
        if(score == 5)
        {
            SceneManager.LoadScene(1);
        }
    }
    
    public void AddFishScore()
    {
        FishScore += 1;
        fishCount.text = $"Fish Count: {FishScore}";
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
