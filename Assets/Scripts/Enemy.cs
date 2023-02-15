using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Parent enemy class
    //all enemies will have hitpoints,damage, coins that they drop, health, movespeed
    // they all have sprites & animations, they all have states
    #region Variables for all enemies
    [SerializeField] protected float hitPoints;
    [SerializeField] protected float damage;
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float health;
    [SerializeField] protected bool isAttacking;
    [SerializeField] protected float coinDropCount;
    [SerializeField] protected GameObject coinPrefab;
    [SerializeField] protected Animator animator;
    [SerializeField] protected GameObject enemyModel;
    #endregion
    private void Start()
    {

        AttackPlayer();
    }

    protected virtual void AttackPlayer()
    {

    }
    protected virtual void DropCoins()
    {

    }
}
   
