using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : MonoBehaviour
{
    [SerializeField] protected float damage;
    
    public virtual void Fire()
    {
        
    }
}
