using UnityEngine;
using System.Collections;
using System;

namespace State.EnemyStateEnum
{
    public class Enemy : MonoBehaviour
    {
        // define simple enumeration with differnt states for enemy object
        private enum EnemyState { Attack, Rest, Dead }

        // keep track of the current state of this object
        private EnemyState currentState;

        // Use this for initialization
        void Start()
        {
            //set rest as a default state
            currentState = EnemyState.Rest;
        }

        // Update is called once per frame
        void Update()
        {
            //each frame we update behavior depending on current state
            switch (currentState)
            {
                case EnemyState.Rest:
                    Resting();
                    break;
                case EnemyState.Attack:
                    Attacking();
                    break;
                case EnemyState.Dead:
                    BeingDead();
                    break;
            }
        }

        /// <summary>
        /// simple dead state function
        /// consider more advanced logic appropriate to your game
        /// </summary>
        private void BeingDead()
        {
            this.GetComponent<Renderer>().material.color = Color.black;
            Debug.Log("I am dead.");
        }

        /// <summary>
        /// simple attacking function
        /// consider more advanced logic appropriate to your game
        /// </summary>
        private void Attacking()
        {
            this.GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("I am attacking!");
        }

        /// <summary>
        /// simple resting or idle mode function
        /// consider more advanced logic appropriate to your game
        /// </summary>
        private void Resting()
        {
            this.GetComponent<Renderer>().material.color = Color.white;
            Debug.Log("I am resting.");
        }

        public void SetRestState()
        {
            currentState = EnemyState.Rest;
        }

        public void SetDeadState()
        {
            currentState = EnemyState.Dead;
        }

        public void SetAttackState()
        {
            currentState = EnemyState.Attack;
        }
    }
}