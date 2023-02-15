using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    [SerializeField] protected short  points;

    
    private void Update()
    {
        transform.Rotate(0 ,0, rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Teros")
        {
            other.GetComponent<PlayerInventory>().AddCoins(points);
            PickCoin();
        }
    }
    public void PickCoin()
    {
        Destroy(gameObject);
    }
}
