using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //Variables
    [SerializeField]
    private float _speed;
    
    //[SerializeField]
    //private float _rotationSpeed;

    private Rigidbody2D _rigidbody;
    private Vector2 _movementInput;
    //private Vector2 _smoothedMovementInput;
    //private Vector2 _movementInputSmoothVelocity;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _movementInput * _speed;
        //_rigidbody.velocity = new Vector2(1, 0.5f);
        //SetPlayerVelocity();
        //RotateInDirectionOfInput();
    }
    //Player speed
    //private void SetPlayerVelocity()
    //{
        //_smoothedMovementInput = Vector2.SmoothDamp(
            //_smoothedMovementInput, 
            //_movementInput, ref _movementInputSmoothVelocity, 0.1f);

        //_rigidbody.velocity = _smoothedMovementInput * _speed;
    //}
    //Player rotation
    //private void RotateInDirectionOfInput()
    //{
    //if (_movementInput != Vector2.zero)
    //{
    //Quaternion targetRotation = Quaternion.LookRotation(transform.forward, _smoothedMovementInput);
    //Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, _rotationSpeed * Time.deltaTime);

    //_rigidbody.MoveRotation(rotation);
    //}
    //}
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.up = direction;
    }

    private void OnMove(InputValue inputValue)
    {
        _movementInput = inputValue.Get<Vector2>();
    }
}
