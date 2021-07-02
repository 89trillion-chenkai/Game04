using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChangeControl : MonoBehaviour
{
    private Animator animator;
    private KeyCode lastButton;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (!Input.GetKeyDown(lastButton)) //如果和上次按键不同才进入
        {
            if (Input.GetKeyDown(KeyCode.A)) //攻击
            {
                animator.SetBool("attackTrigger", true);
                lastButton = KeyCode.A;
            }
            else if (Input.GetKeyDown(KeyCode.R)) //跑步
            {
                animator.SetBool("runTrigger", true);
                lastButton = KeyCode.R;
            }
            else if (Input.GetKeyDown(KeyCode.I)) //闲置
            {
                animator.SetBool("waitTrigger", true);
                lastButton = KeyCode.I;
            }
        }
    }
}
