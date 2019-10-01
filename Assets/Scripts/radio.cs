using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radio : MonoBehaviour
{public static radio inst;
    public int Radio;
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
        Gizmos.DrawWireSphere(transform.position,Radio);
    }
}
