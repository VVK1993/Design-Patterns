using UnityEngine;
using System.Collections;
using System;
using Command.ActorCommands;

public class SceneController : MonoBehaviour
{
    public GameObject cubeActor;
    public GameObject sphereActor;

    /// <summary>
    /// private variable used for storing current active actor which is contorlled by user
    /// </summary>
    private GameObject currentActor;

    // Use this for initialization
    void Start()
    {
        //set cube as a current actor when scipt has loaded
        currentActor = cubeActor;
    }

    // Update is called once per frame
    void Update()
    {
        //Check for current actor change
        HandleActorSwitchInput();

        //Check if any command button was pressed
        Command.ActorCommands.Command command = HandleMovementInput();

        if (command != null)
        {
            //execute pressed command for current active actor if command is not null
            command.Execute(currentActor);
        }
    }

    /// <summary>
    /// If user presses button 1 set cube as current actor
    /// If user presses button 2 set sphere as current actor
    /// </summary>
    private void HandleActorSwitchInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentActor = cubeActor;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentActor = sphereActor;
        }
    }

    /// <summary>
    /// If user presses space -> returns jump command
    /// If user presses right arrow -> returns move right command
    /// If user presses left arrow -> returns move left command
    /// </summary>
    /// <returns>returns abstract command</returns>
    private Command.ActorCommands.Command HandleMovementInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            return new JumpCommand();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            return new MoveRightCommand();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            return new MoveLeftCommand();
        }
        else return null;
    }
}
