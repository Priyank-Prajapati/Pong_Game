using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public int scoreLeft = 0, scoreRight=0;
    public Text leftScore, rightScore, win;
    public float movespeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().position = new Vector2(0, Random.Range(-4, 4));
        System.Threading.Thread.Sleep(800);
        GetComponent<Rigidbody2D>().velocity = new Vector2(1,1)*movespeed;
        leftScore = GameObject.Find("Left_Paddle/Canvas/Left_Score").GetComponent<Text>();
        rightScore = GameObject.Find("Right_Paddle/Canvas/Right_Score").GetComponent<Text>();
        win = GameObject.Find("Main Camera/Canvas/Text").GetComponent<Text>();
    }
    void OnCollisionEnter2D(Collision2D col)
    { 
        if (col.gameObject.name == "Border_Right")
        { 
            scoreLeft++;
            leftScore.text = scoreLeft.ToString();
            if (scoreLeft < 15)
                Start();
            else
            {
                win.text = "Left Player is the Winner!";
                Application.Quit();
            }
        }
        if (col.gameObject.name == "Border_Left")
        {
            scoreRight++;
            rightScore.text = scoreRight.ToString();
            if (scoreRight < 15)
                Start();
            else
            {
                win.text = "Right Player is the Winner!";
                Application.Quit();
            }
        }
    }
}
