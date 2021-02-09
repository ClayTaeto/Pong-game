using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeControl;

public class KeepTrackOfScoring : MonoBehaviour
{
    private int Paddle1score = 0;
    private int Paddle2score = 0;
    public Text scoreboard1;
    // Start is called before the first frame update
    void Awake()
    {
        Message.AddListener<PointScored>(OnScore);
        scoreboard1.text = Paddle2score.ToString() + "      " + Paddle1score.ToString();
    }

    void OnDestroy()
    {
        Message.RemoveListener<PointScored>(OnScore);
    }
        void OnScore(PointScored msg) {
        if (msg.player == "Paddle1") {
            Paddle1score++;
        } else {
            Paddle2score++;
        }
        Debug.Log(Paddle1score + "," + Paddle2score);
        scoreboard1.text = Paddle2score.ToString() + "      " + Paddle1score.ToString();
    }
}
