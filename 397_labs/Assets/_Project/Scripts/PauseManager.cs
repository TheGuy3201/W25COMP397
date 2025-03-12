using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace WebGame397
{
    public class PauseManager : MonoBehaviour
    {
        [SerializeField] private Rigidbody player;
        [SerializeField] private List<NavMeshAgent> enemies = new List<NavMeshAgent>();

        public void PauseByTime()
        {
            Time.timeScale = 0f;
        }

        public void UnPauseByTime()
        {
            Time.timeScale = 1f;
        }

        public void PauseByComponents()
        {
            player.constraints = RigidbodyConstraints.FreezeAll;
            foreach (var agent in enemies)
            {
                agent.enabled = false;
            }
        }

        public void UnPauseByComponents()
        {
            player.constraints = RigidbodyConstraints.FreezeRotation;
            foreach (var agent in enemies)
            {
                agent.enabled = true;
            }
        }
    }
}
