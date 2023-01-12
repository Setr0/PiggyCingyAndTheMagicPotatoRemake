using UnityEngine;

public class StoryPlayerMovement : MonoBehaviour
{
    public static void moveLeft(Rigidbody2D rb)
    {
        if(StoryGameController.gameReady) rb.velocity = new Vector2(-4f, 0f);
    }

    public static void moveRight(Rigidbody2D rb)
    {
        if (StoryGameController.gameReady) rb.velocity = new Vector2(4f, 0f);
    }

    public static void stop(Rigidbody2D rb)
    {
        if (StoryGameController.gameReady) rb.velocity = new Vector2(0f, 0f);
    }
}
