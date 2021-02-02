using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float speed;

    public float radius;
    public Vector2 direction;
    public Text scoreboard1;
    //public Text scoreboard2;

    private int Paddle1score = 0;
    private int Paddle2score = 0;
    void Start()
    {
        direction = Vector2.one.normalized;
        radius = transform.localScale.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        if (transform.position.y < GameManager.bottomLeft.y + radius && direction.y < 0)
        {
            direction.y = -direction.y;
        }
        if (transform.position.y > GameManager.topRight.y - radius && direction.y > 0)
        {
            direction.y = -direction.y;
        }


        if (transform.position.x < GameManager.bottomLeft.x + radius && direction.x < 0)
        {
           
            
            Paddle1score++;
            if (Paddle1score == 5)
            {
                Debug.Log("Right player wins!!");
                Time.timeScale = 0;
                enabled = false;
            }
            this.transform.position = new Vector3(0f, 0f, 0f);

        }
        if (transform.position.x > GameManager.topRight.x - radius && direction.x > 0)
        {
            
            
            Paddle2score++;
            if (Paddle2score == 5)
            {
                Debug.Log("Left player wins!!");
                Time.timeScale = 0;
                enabled = false;
            }
            this.transform.position = new Vector3(0f, 0f, 0f);
        }
        print(Paddle1score + "," + Paddle2score);
        scoreboard1.text = Paddle2score.ToString() + "      "+ Paddle1score.ToString();

    }
    void OnTriggerEnter2D(Collider2D other)
        {
            if(other.tag== "Paddle"){
                bool isRight = other.GetComponent<Paddle>().isRight;

                if(isRight == true && direction.x > 0)
                {
                    direction.x = -direction.x;
                }
                if (isRight== false && direction.x <0)
                {
                    direction.x = -direction.x;
                }
            }
        }
    
}
