using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AzarashiController : MonoBehaviour
{
    Rigidbody2D rd2d;

    public float maxHeight;
    public float flapVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake() {
        rd2d = GetComponent<Rigidbody2D>();    
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && transform.position.y < maxHeight){
            flap();
        }
    }

    public void flap(){
        rd2d.velocity = new Vector2(0.0f,flapVelocity);
    }
}
