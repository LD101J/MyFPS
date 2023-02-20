using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Jude.MyFPS
{
    public class ScoreManager : PlayerInventory
    {
        [SerializeField] private GameObject totalCoinsUI;


        private void Start()
        {
            totalCoins = 0;
        }
        private void Update()
        {
            //totalCoins<PlayerInventory>().AddCoins();
        }
    }

}
