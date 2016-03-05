using UnityEngine;
using System.Collections;
using System;

namespace Command.ActorCommands
{
    /// <summary>
    /// Inhereted from abstract Command class
    /// Jump action which can be performed on any game object
    /// </summary>
    public class JumpCommand : Command
    {
        /// <summary>
        /// Performs simple jump action by translating actor's transform
        /// </summary>
        /// <param name="actor">any game object which you want to execute command</param>
        public override void Execute(GameObject actor)
        {
            actor.transform.Translate(0, 0.5f, 0);
        }
    }
}