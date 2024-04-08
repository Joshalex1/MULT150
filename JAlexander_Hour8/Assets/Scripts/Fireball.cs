using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int TakeDamageFromFireball()
        {
            int playerHealth = 100;
            int x = playerHealth - 5;

            return x;
        }


        int TakeDamageFromFireballl(int Damage)
        {

            int playerHealth = 100;
            int y = playerHealth - Damage;

            return y;
        }

        

        int TakeDamageFromFireballll(int Damage, int playerHealth)
        {
            int z = playerHealth - Damage;

            return z;
        }


        int x = TakeDamageFromFireball();
        Debug.Log("Player health: " + x);


        int y = TakeDamageFromFireballl(25);
        Debug.Log("Player health: " + y);

        int z = TakeDamageFromFireballll(30,50);
        Debug.Log("Player health: " + z);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
