using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Health>() && other.GetComponent<Enemy>())
        {
            other.GetComponent<Health>().TakeDamage(_damage);
        }
        Destroy(gameObject);
    }
}
