using System.Collections;
using System.Collections.Generic;
using IDED.Scripting.Pool;
using UnityEngine;

public class AutomaticGun : MonoBehaviour
{
    [SerializeField] private ObjectPool bulletPool;
    [SerializeField] private float shootingTime = 0.1f;
    [SerializeField] private float bulletSpeed = 1f;
    [SerializeField] private Transform shootingPoint;
    
    private void Start()
    {
        InvokeRepeating(nameof(Shoot), 0f, shootingTime);
    }

    private void Shoot()
    {
        ObjectPoolInstance instance = bulletPool.Allocate();
        instance.transform.position = shootingPoint.position;
        instance.GetComponent<Rigidbody>().velocity = shootingPoint.forward * bulletSpeed;
    }
}
