using UnityEngine;
using System.Collections;

namespace Command.ActorCommands
{
    /// <summary>
    /// The 'Command' abstract class
    /// You can define different commands for any type of action
    /// </summary>
    abstract public class Command
    {
        /// <summary>
        /// Performs some action on given actor.
        /// </summary>
        /// <param name="actor">any game object which you want to execute command</param>
        public abstract void Execute(GameObject actor);
    }
}