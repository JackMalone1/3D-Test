using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class health : MonoBehaviour
{
    [SerializeField] int healthLevel = 0;
    [SerializeField] UnityEvent onDamage;

    public void TakeDamage(int damage)
    {
        onDamage.Invoke();
        healthLevel -= damage;

        if(healthLevel <= 0)
        {
            healthLevel = 0;
            Debug.Log("Character died");
        }
    }

    public void OnTookDamage()
    {
        Debug.Log("Character took damage");
    }
}
