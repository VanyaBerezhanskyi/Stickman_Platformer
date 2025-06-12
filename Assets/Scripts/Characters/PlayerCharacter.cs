using UnityEngine;

public class PlayerCharacter : Character
{
    public float health { get; private set; }

    void Awake()
    {
        health = maxHealth;
    }

    public override void ChangeHealth(float value)
    {
        health += value;

        if (health > maxHealth)
        {
            health = maxHealth;
        }

        if (health <= 0)
        {
            Messenger.Broadcast(GameEvent.PLAYER_DEATH);
        }

        Messenger.Broadcast(GameEvent.HEALTH_UPDATED);
    }
}
