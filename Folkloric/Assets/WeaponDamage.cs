using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDamage : MonoBehaviour
{
    public GameObject arma;

    void SpawnWeapon()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            arma.SetActive(true);
        }if(arma == true)
        {

        }

    }    
    
}
