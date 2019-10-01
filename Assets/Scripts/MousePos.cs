using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos : MonoBehaviour
{

 
 void Update() {
     Vector2 MousePos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
transform.position=MousePos;
 }
}
