using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rouletteController : MonoBehaviour
{
    public bool isStart, isStop;
    public float mov, rotSpeed;

    private void Start()
    {
        this.isStart = this.isStop = false;
        this.mov = 0.1F;
        this.rotSpeed = 0;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.isStop = this.isStart ? true : false;
            this.isStart = true;
        }

        if (this.isStart && !this.isStop)
        {
            if (this.rotSpeed < 30)
            {
                this.rotSpeed += this.mov;
            }
            else
            {
                this.rotSpeed = 30;
            }
        }
        else if (this.isStart && this.isStop)
        {
            if (this.rotSpeed > 0)
            {
                this.rotSpeed -= this.mov;
            }
            else
            {
                this.rotSpeed = 0;
                this.isStart = this.isStop = false;
            }
        }
        //this.rotSpeed = 30;
        
        // if (Input.GetMouseButtonUp(0))
        // {
        //     this.rotSpeed = 0;
        // }

        //this.rotSpeed *= 0.9f;
        transform.Rotate(0, 0, this.rotSpeed);
        Debug.Log(this.rotSpeed);
    }
}
