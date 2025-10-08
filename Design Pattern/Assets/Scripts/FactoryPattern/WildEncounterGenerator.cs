using UnityEngine;

public class WildEncounterGenerator : EncounterGenerator
{
    [SerializeField] private GameObject textWild;
    [SerializeField] private GameObject buttonRun;
    [SerializeField] private GameObject buttonCatch;
    protected override void StartFight()
    {
        base.StartFight();
        textWild.SetActive(true);
        buttonRun.SetActive(true);
        buttonCatch.SetActive(true);
    }
}
