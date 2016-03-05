using UnityEngine;
using System.Collections;

namespace Command.ActorCommands
{
    /// <summary>
    /// Inhereted from abstract Command class
    /// Move left action which can be performed on any game object
    /// </summary>
    public class MoveLeftCommand : Command
    {
        /// <summary>
        /// Performs move left action by translating actor's transform
        /// </summary>
        /// <param name="actor">any game object which you want to execute command</param>
        public override void Execute(GameObject actor)
        {
            actor.transform.Translate(-0.5f, 0, 0);
        }
    }
}