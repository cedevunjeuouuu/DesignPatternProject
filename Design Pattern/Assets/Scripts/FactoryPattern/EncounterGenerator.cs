using UnityEngine;

public abstract class EncounterGenerator : MonoBehaviour
{
    [SerializeField] protected GameObject canvasCombat;
    [SerializeField] protected EnemyScriptable[] enemies;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartEncounter();
        }
    }

    protected virtual void StartEncounter()
    {
        PauseGameWhenFight();
        canvasCombat.SetActive(true);
        IEncounter encounter = CreateEncounter();
        encounter.Attack(); // Exemple de démarrage
    }

    protected EnemyScriptable PickRandomPokemon()
    {
        if (enemies.Length == 0) return null;
        return enemies[Random.Range(0, enemies.Length)];
    }

    protected void PauseGameWhenFight()
    {
        Time.timeScale = 0;
    }

    protected abstract IEncounter CreateEncounter();
}