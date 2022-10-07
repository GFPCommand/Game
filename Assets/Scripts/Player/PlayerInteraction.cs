using System.Collections;
using UnityEngine;

class PlayerInteraction : MonoBehaviour
{
    [SerializeField]
    private GameObject _dialog;

    private Door _door;

    private int _dialogNumber = -1; //get from saved data -> WIP

    private string _dialogTag = "ChangeText";
    private string _doorTag = "Door";

    private bool _isDoorInteract;

    private void Awake()
    {
        DialogManagerUI.DialogNumber = _dialogNumber;

        _isDoorInteract = false;
    }

    private void Update(){
        if (Input.GetKeyDown(KeyCode.F) && _isDoorInteract){
            _door.DoorInteraction();
        } else if (Input.GetKeyDown(KeyCode.F) && !_isDoorInteract){
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_dialogTag))
        {
            _dialogNumber++;

            DialogManagerUI.DialogNumber = _dialogNumber;

            StartCoroutine(Dialog(other));
        }  else if (other.gameObject.CompareTag(_doorTag)){
            _door = other.gameObject.GetComponent<Door>();

            _door.DoorTrigger(true);
            _isDoorInteract = true;
        }
    }

    private void OnTriggerExit(Collider other){
        if (other.gameObject.CompareTag(_doorTag)){
            _door = other.gameObject.GetComponent<Door>();

            _door.DoorTrigger(false);
            _isDoorInteract = false;
        }
    }

    IEnumerator Dialog(Collider other)
    {
        _dialog.SetActive(true);

        Destroy(other.gameObject);

        yield return new WaitForSeconds(2f);

        _dialog.SetActive(false);
    }
}
