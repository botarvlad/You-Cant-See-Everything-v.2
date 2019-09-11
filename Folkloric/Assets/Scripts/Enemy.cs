using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health > 0)
        {
            Debug.Log("Am facut sex de " + damage + " lei!");
            Debug.Log("Mai am " + health + " lei!"); 
        }
        else
        {
            Debug.Log("Am ramas fara lei! Is pe datorie!");
        }
        
    }
}
