using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePositional : MonoBehaviour
{
    public static MousePositional mouse;

    private Camera cam;
    private Vector2 mousePos = new Vector2();
    private Vector3 point = new Vector3();

    void Start()
    {
        if(mouse == null)
            mouse = this;
        else
            Destroy(this);

        Cursor.lockState = CursorLockMode.Confined;

        cam = this.GetComponent<Camera>();
    }

    void Update()
    {
        mousePos.x = Input.mousePosition.x;
        mousePos.y = Input.mousePosition.y;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            point = hit.point;
        }
        
        //point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
    }

    public Vector3 GetPosition()
    {
        return point;
    }
}
