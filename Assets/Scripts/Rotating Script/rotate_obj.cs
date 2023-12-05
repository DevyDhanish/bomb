using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_obj : MonoBehaviour
{
    public Transform obj;
    public float sens = 1.3f;
    private float mousex, mousey;
    private float rotx, roty;

    private void Update()
    {
        if (!Input.GetMouseButton(1)) return;

        mousex = Input.GetAxisRaw("Mouse X") * sens * Time.deltaTime;
        mousey = Input.GetAxisRaw("Mouse Y") * sens * Time.deltaTime;

        rotx += mousey;
        roty -= mousex;

        obj.rotation = Quaternion.Euler(rotx, roty, 0f);
    }
}
