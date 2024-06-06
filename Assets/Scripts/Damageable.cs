using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] float HealthPoints;

    public void TakeDamage(float damage)
    {
        HealthPoints = HealthPoints - damage;
    }

    private void Update()
    {
        if (HealthPoints <= 0)
        {
           Destroy(this.gameObject);
        }
    }
}
