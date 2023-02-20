using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Jude.MyFPS
{
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
        #region MyPractise Variables
        [SerializeField] private Transform teros;
        [SerializeField] private NavMeshAgent player;
        [SerializeField] LayerMask Ground, Player;
        //patrolling
        [SerializeField] private Vector3 walkPoint;
        [SerializeField] private bool walkPointSet;
        [SerializeField] private float walkPointRange;
        //attacking
        [SerializeField] private float timeBetweenAttacks;
        [SerializeField] private bool alreadyAttacked;
        //states
        private float isTerosSightRange, isTerosAttackRange;
        private bool inSightRange, inAttackRange;
        #endregion

        //private void Awake()
        //{
        //    #region MYCode
        //    teros = GameObject.Find("Teros").transform;
        //    player = GetComponent<NavMeshAgent>();

        //}
        //private void Update()
        //{
        //    //check for sight & attackrange
        //    inSightRange = Physics.CheckSphere(transform.position, isTerosSightRange, Player);
        //    inAttackRange = Physics.CheckSphere(transform.position, isTerosAttackRange, Player);

        //    //if (!inAttackRange && !inSightRange) Patrolling();
        //    if (inSightRange && inAttackRange) goAttackPlayer();
        //    if (inSightRange && !inAttackRange) ChasePlayer();
        //}
        ////protected void Patrolling()
        ////{
        ////    if (!walkPointSet) SearchWalkPoint();
        ////}

        ////private void SearchWalkPoint()
        ////{
        ////    //calculalate random point in range
        ////    //float randomZ = Random(-walkPointRange, walkPointRange);
        ////    //float randomX = Random.Range(-walkPointRange, walkPointRange);
        ////}

        protected void ChasePlayer()
        {

        }
        protected void goAttackPlayer()
        {

        }
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
}