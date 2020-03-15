using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    private int HomeScore;

    private int OpponentScore;

    public List<BallLauncher> ballLaunchers = new List<BallLauncher>();

    public Text HomeScoreText;

    public Text OpponentScoreText;

    public int WaitTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        HomeScore = 0;
        OpponentScore = 0;
        StartCoroutine(LaunchBall());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementHomeScore()
    {
        HomeScore += 1;
        HomeScoreText.text = HomeScore.ToString();
        StartCoroutine(LaunchBall());
    }

    public void IncrementOpponentScore()
    {
        OpponentScore += 1;
        OpponentScoreText.text = OpponentScore.ToString();
        StartCoroutine(LaunchBall());
    }

    IEnumerator LaunchBall()
    {
        yield return new WaitForSeconds(WaitTime);

        if (ballLaunchers.Count > 0)
        {
            int random = Random.Range(0, ballLaunchers.Count);

            ballLaunchers[random].LaunchBall();
        }
    }
}
