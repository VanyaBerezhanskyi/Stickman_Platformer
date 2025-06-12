using System.Runtime.CompilerServices;
using UnityEngine;

public class PushingStone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Messenger.Broadcast("PLAYER_DEATH"); 
    }
}
