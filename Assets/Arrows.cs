using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour
{
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    Vector3 position = this.transform.position;
        //    position.x--;
        //    this.transform.position = position;
        //}
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    Vector3 position = this.transform.position;
        //    position.x++;
        //    this.transform.position = position;
        //}
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }
    }
}
   /* public float speed = .3f;
  
    public Rigidbody rb;
    
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float xDir = Input.GetAxis("Horizontal");
        float zDir = Input.GetAxis("Vertical");
        Vector3 moveDir = new Vector3(xDir, zDir , 0.0f);
        transform.position += moveDir * speed;


    }*/
    


