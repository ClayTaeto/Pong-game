using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
    
   
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    Vector3 position = this.transform.position;
        //    position.x--;
        //    this.transform.position = position;
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    Vector3 position = this.transform.position;
        //    position.x++;
        //    this.transform.position = position;
        //}
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }
    }
}
