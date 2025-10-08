using UnityEngine;

public class FightEncounter : IEncounter
{
    private EnemyScriptable trainerPokemon;

    public FightEncounter(EnemyScriptable trainerPokemon)
    {
        this.trainerPokemon = trainerPokemon;
    }

    public void Attack()
    {
        Debug.Log($"You attack the trainer’s {trainerPokemon.name}");
    }

    public void Heal()
    {
        Debug.Log("You used a potion");
    }

    public void EnemyAttack()
    {
        Debug.Log($"The trainer’s {trainerPokemon.name} counterattacks");
    }

    public void End()
    {
        Debug.Log("The trainer battle ended");
        Time.timeScale = 1;
    }

    public void Taunt()
    {
        Debug.Log("You taunted the trainer");
    }
}