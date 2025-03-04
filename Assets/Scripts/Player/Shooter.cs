using System.Runtime.CompilerServices;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _firePower;
    [SerializeField] private Transform _gun;

    public void Shoot(float direction)
    {
        GameObject currentBullet = Instantiate(_bullet, _gun.position, Quaternion.identity);
        Rigidbody currentBulletVelocity = currentBullet.GetComponent<Rigidbody>();

        if (direction > 0)
            currentBulletVelocity.linearVelocity = new Vector2(_firePower * 1, currentBulletVelocity.linearVelocity.y);
        else
            currentBulletVelocity.linearVelocity = new Vector3(_firePower * -1, currentBulletVelocity.linearVelocity.y);
    }
}
