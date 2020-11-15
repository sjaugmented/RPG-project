using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat {
    
    public class Health : MonoBehaviour
    {
        [SerializeField] float healthPoints = 100f;
        bool isDead = false;

        public bool IsDead()
        {
            return isDead;
        }

        private void Update() 
        {
            
        }

        public void TakeDamage(float damage) 
        {
            healthPoints = Mathf.Max(healthPoints - damage, 0);
            
            if (healthPoints == 0 && !isDead)
            {
                Die();
            }
        }

        private void Die()
        {
            GetComponent<Animator>().SetTrigger("die");
            // GetComponent<CapsuleCollider>().enabled = false;
            isDead = true;
        }
    }

}

