using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        score = 11;
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
        if(player != null && score>0)
        {
            score -= 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }

        if (score == 0)
        {
            Destroy(player.gameObject);
        }
    }
}
