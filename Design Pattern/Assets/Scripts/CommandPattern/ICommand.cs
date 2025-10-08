using UnityEngine;

public interface ICommand
{
    public void Execute(Vector2 direction);

    public void Undo();
    public void Redo();
}
public class MoveCommand : ICommand
{
    private PlayerController player;
    private Vector2 direction;
    public MoveCommand(PlayerController player) { this.player = player;}
    public void Execute(Vector2 value)
    {
        direction = value;
        player.Move(value);
    }

    public void Undo()
    {
        player.Move( - direction);
    }

    public void Redo()
    {
        player.Move(direction);
    }
}