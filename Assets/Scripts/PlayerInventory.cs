using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

namespace Jude.MyFPS
{
    public class PlayerInventory : MonoBehaviour
    {
       public  UnityEvent<short> onCoinsUpdate = new UnityEvent<short>();
        public short totalCoins;

        private void Start()
        {
            onCoinsUpdate.Invoke(totalCoins);
            totalCoins = 0; //reset the coin counter
        }
        #region Add, Remove & subtract Coins
        public void AddCoins(short _count)
        {
            totalCoins += _count;
            onCoinsUpdate.Invoke(totalCoins);
        }
        void RemoveCoins(short _count)
        {

        }
        public short GetTotalCoins()
        {
            return totalCoins;
        }
        #endregion

    }
}
