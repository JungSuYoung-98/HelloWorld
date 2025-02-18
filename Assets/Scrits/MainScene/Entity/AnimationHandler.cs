using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private static readonly int IsRun = Animator.StringToHash("IsRun");
    private static readonly int IsSide = Animator.StringToHash("IsSide");
    private static readonly int IsUp = Animator.StringToHash("IsUp");

    protected Animator animator;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void Move(Vector2 obj)
    {
        animator.SetBool(IsRun, obj.magnitude > .5f);
    }

    public void Side(Vector2 obj)
    {
        animator.SetBool(IsSide, Mathf.Abs(obj.x) > 0);
    }

    public void Up(Vector2 obj)
    {
        animator.SetBool(IsUp, obj.y > 0);
    }
}
