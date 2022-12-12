using UnityEngine;

public class BackGround : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float animationspeed = 0.7f;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationspeed * Time.deltaTime, 0);
    }
}
