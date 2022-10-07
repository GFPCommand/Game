using UnityEngine;

public class Player : MonoBehaviour
{
    private int _health;
    private int _maxHealth = 100;

    private void Awake()
    {
        _health = _maxHealth;
    }

    private void Update()
    {
        
    }
}
