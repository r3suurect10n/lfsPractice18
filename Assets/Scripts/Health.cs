using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealthPoints;
    [SerializeField] private float _currentHealth;    

    private bool _isAlive;

    private void Awake()
    {
        _currentHealth = _maxHealthPoints;
        _isAlive = true;
    }

    private void Update()
    {
        if (!_isAlive)
            Destroy(gameObject);            
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        CheckIsAlive();
    }

    private void CheckIsAlive()
    {
        if (_currentHealth > 0)
            _isAlive = true;
        else
            _isAlive = false;
    }

    public float GetCurrentHealth()
    {
        return _currentHealth;
    }
}
