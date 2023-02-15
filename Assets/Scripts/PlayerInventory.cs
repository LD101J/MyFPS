using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
   [SerializeField] private short totalCoins;

    private void Start()
    {
        totalCoins = 0;
    }
    #region Add, Remove & subtract Coins
    public void AddCoins(short _count)
    {
        totalCoins += _count;
    }
    void RemoveCoins(short _count)
    {
      
    }
    short GetTotalCoins()
    {
        return totalCoins;
    }
    #endregion
}
