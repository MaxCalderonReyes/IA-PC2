using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareLong : MonoBehaviour
{public static SquareLong inst;
    public float x;
    public float y;
    // Start is called before the first frame update
    private void Awake() {
    if(inst==null){
        inst=this;
    }   
   }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDrawGizmos() {
        Gizmos.color=Color.red;
        Gizmos.DrawWireCube(transform.position,new Vector3(x,y,0));
    }
}
