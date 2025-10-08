using UnityEngine;

public class CombatEncounterGenerator : EncounterGenerator
{
    [SerializeField] private GameObject textCombat;

    protected override IEncounter CreateEncounter()
    {
        textCombat.SetActive(true);

        var trainerPokemon = PickRandomPokemon();
        return new FightEncounter(trainerPokemon);
    }
}