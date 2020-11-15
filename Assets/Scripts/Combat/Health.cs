using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat {
    
    public class Health : MonoBehaviour
    {
        [SerializeField] float healthPoints = 100f;
        bool isAlive = true;

        private void Update() 
        {
            
        }

        public void TakeDamage(float damage) 
        {
            healthPoints = Mathf.Max(healthPoints - damage, 0);
            
            if (healthPoints == 0 && isAlive)
            {
                Die();
            }
        }

        private void Die()
        {
            GetComponent<Animator>().SetTrigger("die");
            isAlive = false;
        }
    }

}

