using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private PlayerController controller;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<PlayerController>();
    }

    private void OnEnable()
    {
        //controller.OnJumpInput += JumpAnimation;
        //controller.OnSlideInput += SlideAnimation;
    }

    private void OnDisable()
    {
        //controller.OnJumpInput -= JumpAnimation;
        //controller.OnSlideInput -= SlideAnimation;
    }

    private void JumpAnimation()
    {
        animator.SetTrigger("Jump");
    }

    private void SlideAnimation()
    {
        animator.SetTrigger("Slide");
    }

    //게임오버되면
    //animator.enabled = false;
}
