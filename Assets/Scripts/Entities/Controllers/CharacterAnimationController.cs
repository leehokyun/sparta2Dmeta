using System;
using UnityEditor.Animations;
using UnityEngine;

public class CharacterAnimationController : AnimationController 
{


    public RuntimeAnimatorController[] anumCon;

    Animator anim;
    AnimatorController[] animCon;

    private static readonly int isWalking = Animator.StringToHash("isWalking");

    private readonly float magnituteThreshold = 0.5f; //?? 이건 뭔기능?

    protected override void Awake()
    {
        base.Awake();

        anim = GetComponentInChildren<Animator>();
        OnEnable();
        
    }

    private void OnEnable()
    {
        anim.runtimeAnimatorController = animCon[GameManager.Instance.playerId];
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);
    }
}