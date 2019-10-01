using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitanteCirculo : MonoBehaviour
{
    static public Vector3 Seek(SbAgents agent, Transform target, float range = 99999)
    {
        Vector3 desired = Vector3.zero;
        Vector3 diferencia = (target.position - agent.transform.position);
        float distance = diferencia.magnitude;
        desired = diferencia.normalized * agent.maxSpeed;
        Vector3 steer;
        if (distance < range)
        {
           steer = Vector3.ClampMagnitude(desired - agent.velocity, agent.maxSpeed);

        }
        else
        {
            steer = Vector3.zero;
        }
        // cálculo del vector deseado
      

        // cálculo de los demás vectores
      

        return steer;
    }

    static public Vector3 Flee(SbAgents agent, Transform target, float range = 99999)
    {
        
        Vector3 desired = Vector3.zero;
        Vector3 diferencia = (target.position - agent.transform.position);
        float distancia = diferencia.magnitude;
        desired = -diferencia.normalized * agent.maxSpeed;
        Vector3 steer;
        if (distancia < range)
        {
            steer = Vector3.ClampMagnitude(desired - agent.velocity, agent.maxSpeed);

        }
        else
        {
            steer = Vector3.zero;
        }


        // cálculo de los demás vectores
      

        return steer;
    }

    static public Vector3 Arrive(SbAgents agent, Transform target, float range)
    {
        // cálculo del vector deseado
        Vector3 desired;
        Vector3 difference = (target.position - agent.transform.position);
        float distance = difference.magnitude;

        desired = difference.normalized * agent.maxSpeed;

        if (distance < range)
        {
            desired *= distance / range;
        }

        // cálculo de los demás vectores
        Vector3 steer = Vector3.ClampMagnitude(desired - agent.velocity, agent.maxSteer);

        return steer;
    }
	public static Vector3 Separate(SbAgents agent,List<GameObject> agentsToAvoid,float range){
    Vector3 steer=Vector3.zero;
	 for(int i=0;i<agentsToAvoid.Count;i++){
      steer+=Flee(agent,agentsToAvoid[i].transform,range);
	 }	
	 return steer;
	}
}
