using UnityEngine;

public class StoryPlayerController : MonoBehaviour
{
    public static void moveLeft(Rigidbody2D rb)
    {
        rb.velocity = new Vector2(-2f, 0f);
    }

    public static void moveRight(Rigidbody2D rb)
    {
        rb.velocity = new Vector2(2f, 0f);
    }

    public static void stop(Rigidbody2D rb)
    {
        rb.velocity = new Vector2(0f, 0f);
    }
}
