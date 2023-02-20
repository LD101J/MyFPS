using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCoins : MonoBehaviour
{
    public void SetCoinText(short coins)
    {
        GetComponent<TMP_Text>().text =  coins.ToString();
    }
}