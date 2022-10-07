using System.Threading.Tasks;
using UnityEngine;

public class FadeScreen : MonoBehaviour, ICheckAnimations
{
    private string _animationName = "Base.FadeIn";

    [SerializeField]
    private GameObject _fade;

    private Animator _fadeAnimator;

    private ICheckAnimations _check;

    private void Start()
    {
        _check = this;

        _fadeAnimator = _fade.GetComponent<Animator>();
    }

    public async void Playing()
    {
        _fade.SetActive(true);

        while (_check.IsAnimationPlaying(_animationName, _fadeAnimator))
        {
            await Task.Yield();
        }
    }
}
