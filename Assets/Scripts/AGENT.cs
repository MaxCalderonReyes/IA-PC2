using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AGENT : SbAgents
{
   public bool cuadrado;
    public Transform target;

    void Start()
    {

        maxSpeed = 10f;
        maxSteer = 1f;
        
    }

    void Update()
    {
        if(!cuadrado){
 if(transform.position.magnitude<radio.inst.Radio){
        velocity += LimitanteCirculo.Arrive(this, target, 3);
      
 transform.position += velocity * Time.deltaTime;

        }else{
      
        transform.position-=velocity*Time.deltaTime;
        }
        }
 if(cuadrado){
     if(transform.position.magnitude<new Vector3((SquareLong.inst.x/2),(SquareLong.inst.y/2)-1,0).magnitude){
        velocity += LimitanteCirculo.Arrive(this, target, 3);
      
 transform.position += velocity * Time.deltaTime;
 }
 else{
    transform.position-=velocity*Time.deltaTime;
 }
        
       
}
}
}
