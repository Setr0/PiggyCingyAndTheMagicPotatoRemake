using UnityEngine;

public class RocksMovement : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector2(transform.position.x,
            transform.position.y + 10f * Time.deltaTime);

        if(transform.position.y >= 1.97f)
        {
            Destroy(gameObject);
        }
    }
}
