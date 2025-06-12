using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public float points = 50.0f;

    void OnTriggerStay2D(Collider2D other)
    {
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();

        if (player != null && player.health < player.maxHealth)
        {
            player.ChangeHealth(points);

            Destroy(gameObject);
        }
    }
}
