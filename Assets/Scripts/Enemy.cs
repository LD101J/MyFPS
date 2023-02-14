using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected float hitPoints = 100f;
    [SerializeField] protected float moveSpeed = 20f;
    [SerializeField] protected float coinCount = 10;
    [SerializeField] protected GameObject coinPrefab;
    [SerializeField] protected Animator animator;
    [SerializeField] protected GameObject enemyModel;
    protected virtual void AttackPlayer()
    {

    }
    protected virtual void DropCoins()
    {

    }
    private void Start()
    {
        
        AttackPlayer();
    }
}
