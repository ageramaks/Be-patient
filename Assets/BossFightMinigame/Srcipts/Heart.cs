using UnityEngine;

public class Heart : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            Destroy(gameObject);
            Lose();
        }
    }

    private void Lose()
    {
        Debug.Log("You die");
    }
}
