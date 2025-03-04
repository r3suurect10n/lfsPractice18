using Unity.VisualScripting;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private Shooter _shooter;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _shooter = GetComponent<Shooter>();
    }

    private void Update()
    {
        float horizontalDirection = Input.GetAxis("Horizontal");
        bool isJump = Input.GetButtonDown("Jump");

        if (Input.GetButtonDown("Fire1"))
            _shooter.Shoot(horizontalDirection);

        _playerMovement.Move(horizontalDirection, isJump);
    }
}
