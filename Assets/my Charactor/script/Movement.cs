using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    CharacterController characterController;
    void Start()
    {
        anim = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();

        anim.SetBool("isSalute", true);
        anim.SetBool("isDance", false);
        anim.SetBool("isHipHop", false);
        //Time to start the animation
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S)){
            anim.SetBool("isSalute", true);
            anim.SetBool("isDance", false);
            anim.SetBool("isHipHop", false);
        }
        else if (Input.GetKey(KeyCode.D)){
            anim.SetBool("isDance", true);
            anim.SetBool("isSalute", false);
            anim.SetBool("isHipHop", false);
        }
        else if (Input.GetKey(KeyCode.W)){
            anim.SetBool("isHipHop", true);
            anim.SetBool("isSalute", false);
            anim.SetBool("isDance", false);
        }
        else if (Input.GetKey(KeyCode.A)){
            anim.SetBool("isHipHop", false);
            anim.SetBool("isSalute", false);
            anim.SetBool("isDance", false);
        }
    }
}
