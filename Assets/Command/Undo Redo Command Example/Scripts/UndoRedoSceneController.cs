using UnityEngine;
using System.Collections;
using Command.UndoRedoCommands;

public class UndoRedoSceneController : MonoBehaviour
{
    public GameObject actor;

    // Use this for initialization
    void Start()
    {

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
            return new MoveActorCommand(actor, 0, 0.5f);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            return new MoveActorCommand(actor, 0.5f, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            return new MoveActorCommand(actor, -0.5f, 0);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            return new MoveActorCommand(actor, 0, -0.5f);
        }
        else return null;
    }
}
