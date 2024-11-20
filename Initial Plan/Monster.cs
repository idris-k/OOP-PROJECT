using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace swarmgame2
{
    public class Monster
    {
        public int Health { get; set; }
        public Vector2 Position { get; set; }
        public float Speed { get; set; }

        public void Move()
        {
            // Logic to move the monster
            
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Die();
            }
        }

        public void Attack()
        {
            // Logic for the monster to attack
        }

        public void Die()
        {
            // Logic to handle monster death
        }
    }


}
