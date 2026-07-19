using UnityEngine;

public class Despawners : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {        
        Destroy(collision.gameObject);
    }
}
