using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;
    public GameManagerScript gm;

    // Start is called before the first frame update
    void Start()
    {
        score = 11;
    }
    // Update is called once per frame
    void Update()
    {
        if (score > 0)
        {
            score -= Time.deltaTime;
        }
        else
        {
            score = 0;
            Debug.Log("Time's up");
            gm.OnTimerEnd();
            
        }

        scoreText.text = ((int)score).ToString();
    }
}
