using UnityEngine;
using System.Collections;

namespace Command.UndoRedoCommands
{
    public abstract class Command
    {
        protected GameObject actor;

        public Command(GameObject actor)
        {
            this.actor = actor;
        }

        public abstract void Execute();

        public abstract void Undo();
    }
}
