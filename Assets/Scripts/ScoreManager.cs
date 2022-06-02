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
        gm = FindObjectOfType<GameManagerScript>();
        score = 31;
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
