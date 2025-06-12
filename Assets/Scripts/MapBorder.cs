using UnityEngine;

public class MapBorder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Messenger.Broadcast(GameEvent.PLAYER_DEATH);
    }
}
