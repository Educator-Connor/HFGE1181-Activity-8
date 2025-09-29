using UnityEngine;

public class OnDamage : MonoBehaviour
{
    public GameObject collisionParticle;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Instantiate(collisionParticle,transform.position, Quaternion.identity);
            if (CameraShake.Instance != null)
            {
                CameraShake.Instance.Shake(.5f, .15f);
            }
        }  
    }

}
