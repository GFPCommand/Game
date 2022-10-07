using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{
    private CharacterController _controller;

    private float _horizontal;
    private float _vertical;

    private float _gravity = Physics.gravity.y;

    private bool _isGround = true;

    private Transform _groundChecker;

    [SerializeField]
    private float _jumpForce = 2.0f;
    [SerializeField]
    private float _speed = 10.0f;

    [SerializeField]
    private LayerMask _ground;

    private Vector3 _velocity;
    private Vector3 _moveDirection = Vector3.zero;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();

        _groundChecker = transform.GetChild(0);
    }

    private void Update()
    {
        _isGround = Physics.CheckSphere(_groundChecker.position, 0.2f, _ground);

        if (_isGround && _velocity.y < 0)
            _velocity.y = 0f;

        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        _moveDirection = new Vector3(_horizontal, 0, _vertical);

        _controller.Move(_moveDirection * Time.deltaTime * _speed);

        if (Input.GetButtonDown("Jump") && _isGround)
        {
            _velocity.y += Mathf.Sqrt(_jumpForce * -2 * (_gravity - 20));
        }

        _velocity.y += _gravity * Time.deltaTime;

        _controller.Move(_velocity * Time.deltaTime);
    }
}
