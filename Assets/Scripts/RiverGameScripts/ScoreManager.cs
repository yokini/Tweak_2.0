using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;
    public GameManagerScript gm;

    void Start()
    {
        gm = FindObjectOfType<GameManagerScript>();
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
            gm.OnTimerEnd();
        }

        if(gm.TimerOngoing == false)
        {
            scoreText.text = null;
        }

        else
        {
            scoreText.text = ((int)score).ToString();
        }

    }
}
