using UnityEngine;
using System.Collections;

namespace State.EnemyStateOOP
{
    public class DeadState : IState
    {
        // PerformAction plays dead state main action
        // For example, it could be explosion animation
        public virtual void PerformAction(Monster monster)
        {
            //add some logic here for your real game
            Debug.Log("I am dead.");
        }

        // Here you can place specific logic to prepare an object for DeadState
        // For example, change behavior or looks
        public virtual void EnterState(Monster monster)
        {
            Debug.Log("I am entering dead state");
            monster.GetComponent<Renderer>().material.color = Color.black;
        }

        // Here you can place specific logic to clean up resources
        // For example, free memory
        public virtual void ExitState(Monster monster)
        {
            Debug.Log("I am exiting dead state");
            monster.CleanUp();
        }
    }
}
