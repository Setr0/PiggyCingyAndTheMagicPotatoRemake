using UnityEngine;

public class RocksController : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector2(transform.position.x,
            transform.position.y + 10f * Time.deltaTime);

        if(transform.position.y >= 1.97f || StoryGameController.reachedScore)
        {
            Destroy(gameObject);
        }
    }
}
