using UnityEngine;

interface ICheckAnimations
{
    public bool IsAnimationPlaying(string animationName, Animator animator)
    {
        var animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (animatorStateInfo.IsName(animationName))
        {
            return true;
        }
        return false;
    }
}