using UnityEngine;
using System.Collections;

namespace State.EnemyStateOOP
{
    public interface IState
    {
        /// <summary>
        /// Performs some action 
        /// </summary>
        void PerformAction(Monster monster);

        /// <summary>
        /// Setting up the monster object when entered new state
        /// </summary>
        void EnterState(Monster monster);

        /// <summary>
        /// Cleaning up the monster object before exiting current state
        /// </summary>
        void ExitState(Monster monster);
    }
}
