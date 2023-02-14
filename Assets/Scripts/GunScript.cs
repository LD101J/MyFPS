using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private float range;
    [SerializeField] private Camera fpsCamera;
    [SerializeField] private ParticleSystem muzzleFlash;
    [SerializeField] private float fireRate;
    [SerializeField] private GameObject impactEffect;
     private float nextFire = 0f;
   
    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time  >= nextFire)
        {
            nextFire = Time.time + 1f / fireRate;
            Shoot();
            
        }
    }

     void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hit;
        if(Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward , out hit, range))
        {
            Destroy target = hit.transform.GetComponent<Destroy>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 1f);
        } 
    }
}
