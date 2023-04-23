using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool isSelected;
    void Update()
    {
        if (isSelected == true)
        {
            Vector2 mousePoz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePoz.x, mousePoz.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            isSelected = false;
        }


    }
    private void OnMouseOver()// mouse ile ellediği cisim
    {

    }
    void OnMouseEnter()// merkezden tutunca 
    {

    }
    void OnMouseDown()// overla ayni işlemi yapar
    {
        if (Input.GetMouseButton(0))
        {
            isSelected = true;
        }
    }
}
