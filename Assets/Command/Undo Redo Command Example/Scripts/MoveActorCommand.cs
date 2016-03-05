using UnityEngine;
using System.Collections;
using System;

namespace Command.UndoRedoCommands
{
    public class MoveActorCommand : Command
    {
        private Vector3 positionBefore;
        private float x;
        private float y;

        public MoveActorCommand(GameObject actor, float x, float y) : base(actor)
        {
            this.x = x;
            this.y = y;
        }

        public override void Execute()
        {
            // Remember the unit's position before the move
            // so we can restore it.
            positionBefore = actor.transform.position;

            actor.transform.Translate(x, y, 0);
        }

        public override void Undo()
        {
            actor.transform.position = positionBefore;
        }
    }
}
