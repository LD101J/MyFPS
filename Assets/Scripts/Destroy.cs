using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //all destructuble have health
    [SerializeField] private float maxhealth;
    //this is the gameobject of the particle system that will detect
    [SerializeField] private ParticleSystem bullet;

    private void Start()
    {
        //health = maxhealth;
    }
    public void TakeDamage(float amount)
    {
        //health -= amount;
        //if(health <= 0)
        //{
        //    Die();
        //}
             
    }

     void Die()
    {
        Destroy(gameObject);
    }
}
