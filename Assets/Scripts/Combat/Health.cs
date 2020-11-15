using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat {
    
    public class Health : MonoBehaviour
    {
        [SerializeField] float health = 100f;
        bool isAlive = true;

        private void Update() 
        {
            if (health < 1 && isAlive) {
                GetComponent<Animator>().SetTrigger("die");
                isAlive = false;
            }
        }

        public void TakeDamage(float damage) 
        {
            health = Mathf.Max(health - damage, 0);
            print("health= " + health);
        }
    }

}

