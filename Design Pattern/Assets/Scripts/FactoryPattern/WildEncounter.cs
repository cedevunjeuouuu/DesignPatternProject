using UnityEngine;

public class WildEncounter : IEncounter
{
    private EnemyScriptable pokemon;

    public WildEncounter(EnemyScriptable pokemon)
    {
        this.pokemon = pokemon;
    }

    public void Attack()
    {
        Debug.Log($"You attack the wild {pokemon.name}!");
    }

    public void Heal()
    {
        Debug.Log("You used a potion");
    }

    public void EnemyAttack()
    {
        Debug.Log($"The wild {pokemon.name} attacks");
    }

    public void End()
    {
        Debug.Log("The wild encounter ended");
        Time.timeScale = 1;
    }

    public void Capture()
    {
        Debug.Log($"You tried to catch {pokemon.name}");
    }

    public void Flee()
    {
        Debug.Log("You fled from battle");
        End();
    }
}