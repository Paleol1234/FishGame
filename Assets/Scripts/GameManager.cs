using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public Text text;
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
