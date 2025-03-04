using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _damagePlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
            other.GetComponent<Health>().TakeDamage(_damagePlayer);
    }
}
