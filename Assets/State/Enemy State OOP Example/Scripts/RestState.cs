using UnityEngine;
using System.Collections;

namespace State.EnemyStateOOP
{
    public class RestState : IState
    {
        // PerformAction plays rest state main action
        // For example, it could be "sleeping"
        public virtual void PerformAction(Monster monster)
        {
            //add some logic here for your real game
            Debug.Log("I am resting.");
        }

        // Here you can place specific logic to prepare an object for RestState
        // For example, change behavior or looks
        public virtual void EnterState(Monster monster)
        {
            Debug.Log("I am entering rest state");
            monster.GetComponent<Renderer>().material.color = Color.white;
        }

        // Here you can place specific logic to clean up resources
        // For example, free memory
        public virtual void ExitState(Monster monster)
        {
            Debug.Log("I am exiting rest state");
            monster.CleanUp();
        }
    }
}
