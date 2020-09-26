using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Animate : MonoBehaviour
{
   
    //SpriteRenderer sr;
    Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
       
        Anim = GetComponent<Animator>();
     
    }

    // Update is called once per frame
    void Update()
    {
        GameObject TIME = GameObject.FindGameObjectWithTag("Time");
        TimeCount TMC = TIME.GetComponent<TimeCount>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Anim.SetInteger("Status", 3);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            Anim.SetInteger("Status", 1);
        }
        else if (TMC.timer == 0)
            {
                Anim.SetInteger("Status", 0);
            }
        else if (Input.GetKey(KeyCode.D))
            {
                Anim.SetInteger("Status", 2);
            }
        else if (Input.GetKeyUp(KeyCode.D))
            {
                Anim.SetInteger("Status", 1);
            }
        else if (Input.GetKey(KeyCode.A))
            {
                Anim.SetInteger("Status", 2);
            }
        else if (Input.GetKeyUp(KeyCode.A))
            {
                Anim.SetInteger("Status", 1);
            }
              
    }
}
