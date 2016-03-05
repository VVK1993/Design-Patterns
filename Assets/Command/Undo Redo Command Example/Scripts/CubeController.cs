using UnityEngine;
using System.Collections;
using Command.UndoRedoCommands;
using System.Collections.Generic;

public class CubeController : MonoBehaviour
{
    private const float step = 0.5f;
    private Stack<Command.UndoRedoCommands.Command> undoStack;
    private Stack<Command.UndoRedoCommands.Command> redoStack;

    // Use this for initialization
    void Start()
    {
        undoStack = new Stack<Command.UndoRedoCommands.Command>();
        redoStack = new Stack<Command.UndoRedoCommands.Command>();
    }

    // Update is called once per frame
    void Update()
    {
        //Check if any command button was pressed
        Command.UndoRedoCommands.Command command = HandleMovementInput();

        if (command != null)
        {
            //execute pressed command for current active actor if command is not null
            command.Execute();
            undoStack.Push(command);
        }
    }

    /// <summary>
    /// If user presses space -> returns jump command
    /// If user presses right arrow -> returns move right command
    /// If user presses left arrow -> returns move left command
    /// </summary>
    /// <returns>returns abstract command</returns>
    private Command.UndoRedoCommands.Command HandleMovementInput()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            return new MoveActorCommand(this.gameObject, 0, step);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            return new MoveActorCommand(this.gameObject, step, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            return new MoveActorCommand(this.gameObject, -step, 0);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            return new MoveActorCommand(this.gameObject, 0, -step);
        }
        else return null;
    }

    public void UndoCommand()
    {
        if (undoStack.Count != 0)
        {
            var command = undoStack.Pop();
            command.Undo();
            redoStack.Push(command);
        }
    }

    public void RedoCommand()
    {
        if (redoStack.Count != 0)
        {
            var command = redoStack.Pop();
            command.Execute();
            undoStack.Push(command);
        }
    }
}
