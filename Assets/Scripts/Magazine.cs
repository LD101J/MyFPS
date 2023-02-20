using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Jude.MyFPS
{
    public class Magazine : MonoBehaviour
    {
        [SerializeField] private int bulletStore;
        #region MyCode
        [SerializeField] private Text ammoText;
        [SerializeField] private Text maxAmmoText;
        
        void UpdateAmmo(int count)
        {
            ammoText.text = "Ammo :" + count;
        }
            #endregion

        public void GetBullet()
        {
            bulletStore--;
        }
    }
}
