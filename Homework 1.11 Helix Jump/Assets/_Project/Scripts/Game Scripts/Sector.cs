using UnityEngine;

public class Sector : MonoBehaviour
{
    public bool IsGood = true;
    public Material BadMaterial;
    public Material GoodMaterial;

    private void OnCollisionStay(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out Player player)) return;
        Vector3 collisionNormal = -collision.contacts[0].normal.normalized;
        float dot = Vector3.Dot(collisionNormal, Vector3.up);
        if (dot < 0.5) return;
        if (IsGood) player.Bounce();
        else player.Die();       
    }


    private void Awake()
    {
        setColor();
    }

    private void OnValidate()
    {
        setColor();
    }

    private void setColor()
    {
        GetComponent<Renderer>().sharedMaterial = IsGood ? GoodMaterial : BadMaterial;
    }
}
