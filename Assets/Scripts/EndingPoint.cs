using UnityEngine;

public class FinishingPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Messenger.Broadcast(GameEvent.LEVEL_COMPLETE);
    }
}
