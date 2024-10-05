using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swarmgame2
{
    public class Swarm
    {
        public List<Monster> Monsters { get; set; }
        public float SwarmSpeed { get; set; }

        public Swarm()
        {
            Monsters = new List<Monster>();
        }

        public void MoveSwarm()
        {
            foreach (var monster in Monsters)
            {
                monster.Move();
            }
        }

        public void UpdateSwarm()
        {
            // Logic to update the state of the swarm (e.g., adding new monsters)
        }

        public void SpawnNew()
        {
            // Logic to spawn a new monster
            Monsters.Add(new Monster());
        }
    }
}
