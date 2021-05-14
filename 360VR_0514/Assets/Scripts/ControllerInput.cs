using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{
    public Material mat; //cube's material
    public Transform tr; // 움직일 cube 지정

    public float speed; // cube's speed

    private float dirX = 0;
    private float dirZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        TestButtonDownUp();
        MoveObject();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TestButtonDownUp()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            mat.color = Color.blue;
        }
        else if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            mat.color = Color.red;
        }


    }

    void MoveObject()
    {
        dirX = 0;
        dirZ = 0;

        if (OVRInput.Get(OVRInput.Touch.PrimaryThumbstick))
        {
            Vector2 coord = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

            var absX = Mathf.Abs(coord.x);
            var absZ = Mathf.Abs(coord.y);

            if (absX > absZ)
            {
                if (coord.x > 0)
                {
                    dirX = +1;
                }
                else
                {
                    dirX = -1;
                }
            }
            else
            {
                if (coord.y > 0)
                {
                    dirZ = +1;
                }
                else
                {
                    dirZ = -1;
                }
            }
        }

        Vector3 moveDir = new Vector3(dirX * speed, 0, dirZ * speed);
        tr.Translate(moveDir * Time.smoothDeltaTime);
    }
}
