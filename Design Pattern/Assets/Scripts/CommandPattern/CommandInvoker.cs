using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker
{
    
    private Stack<MoveCommand> _directionStack = new Stack<MoveCommand>();
    private Stack<MoveCommand> redoStack = new Stack<MoveCommand>();

    public CommandInvoker() { }
    public void NewCommand(Vector2 direction, PlayerController player)
    {
        MoveCommand actualCommand = new MoveCommand(player);
        actualCommand.Execute(direction);
        _directionStack.Push(actualCommand);
    }
    public void Undo()
    {
        if (_directionStack.Count != 0)
        {
            redoStack.Push(_directionStack.Peek());
            _directionStack.Pop().Undo();
        }
    }
    public void Redo()
    {
        if (redoStack.Count != 0)
        {
            _directionStack.Push(redoStack.Peek());
            redoStack.Pop().Redo();
        }
    }

    public void EmptyRedo()
    {
        redoStack.Clear();
    }
}
