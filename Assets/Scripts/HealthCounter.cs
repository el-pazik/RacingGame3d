using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthCounter : MonoBehaviour
{
    [SerializeField] private Text healthText;
    public UnityEvent OnDeath;

    private int _health;

    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
            healthText.text = $"{_health}";
            if(_health <= 0)
            {
                OnDeath?.Invoke();
            }
        }
    }

    private void Start()
    {
        Health = 1;
    }
}
