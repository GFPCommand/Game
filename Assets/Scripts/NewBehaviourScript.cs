using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        this.GetComponent<Animator>().SetBool("open", true);
    }
}
