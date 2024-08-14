using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamAnim : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    bool right = true;
    bool left = false;
    void Update()
    {

        if (Input.GetKey(KeyCode.E))
        {
            if (right == true)
            {
                anim.SetBool("idle", false);
                anim.SetBool("left", false);
                anim.SetBool("right", true);
                left = false;
            }

        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            left = true;
            anim.SetBool("left", false);
            anim.SetBool("right", false);
            anim.SetBool("idle", true);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            if (left == true)
            {
                anim.SetBool("left", true);
                anim.SetBool("idle", false);
                anim.SetBool("false", false);
                right = false;
            }


        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            right = true;
            anim.SetBool("left", false);
            anim.SetBool("right", false);
            anim.SetBool("idle", true);

        }
        /*            else if(Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.E))
                    {

                    anim.SetBool("idle", false);
                    anim.SetBool("left", false);
                    anim.SetBool("right", false);
                }*/
        /*    else if (Input.GetKeyDown(KeyCode.Q) && Input.GetKeyDown(KeyCode.E))
            {

            }*/
/*        else
        {
            anim.SetBool("left", false);
            anim.SetBool("right", false);
            anim.SetBool("idle", true);

        }*/
        }
    
}
