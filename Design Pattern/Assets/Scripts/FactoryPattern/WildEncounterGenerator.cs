using UnityEngine;

public class WildEncounterGenerator : EncounterGenerator
{
    [SerializeField] private GameObject textWild;
    [SerializeField] private GameObject buttonRun;
    [SerializeField] private GameObject buttonCatch;

    protected override IEncounter CreateEncounter()
    {
        textWild.SetActive(true);
        buttonRun.SetActive(true);
        buttonCatch.SetActive(true);

        var wildPokemon = PickRandomPokemon();
        return new WildEncounter(wildPokemon);
    }
}