using UnityEngine;

public class StoryPlayerMovement : MonoBehaviour
{
    public static void moveLeft(Rigidbody2D rb)
    {
        if(StoryGameController.gameReady && !StoryGameController.reachedScore) rb.velocity = new Vector2(-6f, 0f);
    }

    public static void moveRight(Rigidbody2D rb)
    {
        if(StoryGameController.gameReady && !StoryGameController.reachedScore) rb.velocity = new Vector2(6f, 0f);
    }

    public static void stop(Rigidbody2D rb)
    {
        if(StoryGameController.gameReady && !StoryGameController.reachedScore) rb.velocity = new Vector2(0f, 0f);
    }
}
