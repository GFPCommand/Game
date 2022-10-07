using UnityEngine;
using TMPro;

public class Door : MonoBehaviour
{
    [SerializeField]
    private Animator _doorAnimator;

    [SerializeField]
    private TMP_Text _interactionText;

    [SerializeField]
    private GameObject _interactionTextObj;

    private string _animatorTag = "open";

    private bool _isOpen;
    public void DoorTrigger(bool isTrigger){
        _interactionText.text = "Press F to open door";
        _interactionTextObj.SetActive(isTrigger);
    }

    public void DoorInteraction(){
        if (!_isOpen){
            OpenDoor();
            _isOpen = true;
        } else {
            CloseDoor();
            _isOpen = false;
        }
    }

    private void OpenDoor(){
        _doorAnimator.SetBool(_animatorTag, true);
    }

    private void CloseDoor(){
        _doorAnimator.SetBool(_animatorTag, false);
    }
}
