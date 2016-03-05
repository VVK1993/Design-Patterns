using UnityEngine;
using System.Collections;
using System;

namespace State.EnemyStateOOP
{
    public class Monster : MonoBehaviour
    {
        //private members:
        private IState currentState;

        /**
         * Awake assings the RestState to the monster
         */
        private void Awake()
        {
            currentState = new RestState();
        }

        private void ChangeState(IState state)
        {
            // before changing state we should properly 'exit' from the current state
            currentState.ExitState(this);
            // than we can set new state
            currentState = state;
            // and perform state initializing logic
            currentState.EnterState(this);

        }

        public void SetRestState()
        {
            ChangeState(new RestState());
        }

        public void SetDeadState()
        {
            ChangeState(new DeadState());
        }

        public void PerformStateAction()
        {
            currentState.PerformAction(this);
        }

        public void SetAttackState()
        {
            ChangeState(new AttackState());
        }

        public void CleanUp()
        {
            // nothing here
            // but you can place real cleaning logic appropriate for your game
        }
    }
}