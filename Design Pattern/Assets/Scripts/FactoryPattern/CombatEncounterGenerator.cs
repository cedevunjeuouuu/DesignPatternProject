using UnityEngine;

public class CombatEncounterGenerator : EncounterGenerator
{
    [SerializeField] private GameObject textCombat;
    protected override void StartFight()
    {
        base.StartFight();
        textCombat.SetActive(true);
    }
}
