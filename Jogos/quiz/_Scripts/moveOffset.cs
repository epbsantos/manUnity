using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOffset : MonoBehaviour
{

    private Material materialLocal;
    private float offsetX = 0;
    private float offsetY = 0;

    public bool onlyX = false;
    public float velocity = 0.0015f;


    // Start is called before the first frame update
    void Start()
    {
        materialLocal = GetComponent<Renderer>().material;
    }

    private void FixedUpdate()
    {
        offsetX = velocity + offsetX;

        if(onlyX)
        {
            offsetY = 0;
        }
        else
        {
            offsetY += velocity;
        }
        

        materialLocal.SetTextureOffset(
            "_MainTex",
            new Vector2(offsetX, offsetY));
    }
}
