using UnityEngine;

public class LoopingBackGround : MonoBehaviour
{
   public float backgroundSpeed = 0.1f;
   private Renderer backgroundRenderer;

    void Start()
    {
        
        backgroundRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        
        float offset = backgroundSpeed * Time.time;

        
        backgroundRenderer.material.mainTextureOffset = new Vector2(offset, 0f);
    }
}
