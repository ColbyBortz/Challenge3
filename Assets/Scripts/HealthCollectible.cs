using UnityEngine;

/// <summary>
/// Will handle giving health to the character when they enter the trigger.
/// </summary>
public class HealthCollectible : MonoBehaviour 
{
    public GameObject PickUpEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            Instantiate(PickUpEffect, transform.position + Vector3.up * 0.5f, Quaternion.identity);
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
}
