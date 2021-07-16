using UnityEngine;

public class Person : MonoBehaviour
{
    [SerializeField] private GameObject game;
    [SerializeField] private GameObject lose;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.TryGetComponent(out EnemyMove enemyMove))
        {
            game.SetActive(false);
            lose.SetActive(true);
        }
    }
}
