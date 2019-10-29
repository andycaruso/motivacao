using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotSpotClick : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 lastPoint;
    // Start is called before the first frame update
    void Start()
    {
        //_r.SetPos1(new Vector2(0f, 0f));
        //   _r.SetPos2(new Vector2(10f, 10f));
        // _r.DesenhaRetangulo();
        rb = GetComponent<Rigidbody>();

    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 vect3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            vect3 = Camera.main.ScreenToWorldPoint(vect3);
            //I made the vector's Z value 0 because the object's Z coordinate is also 0. 
            //This is to capture location in 2D space instead of 3D. This might be the problem. 
            if (lastPoint == null)
            {
                lastPoint = vect3;
                return;
            }
            Debug.DrawLine(lastPoint, vect3, Color.red, 1);
            lastPoint = vect3;
        }
    }
}