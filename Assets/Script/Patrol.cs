using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public List<Transform> steps;

    private NavMeshAgent agent;
    private int currentStep = 0;
    private List<Vector3> interpolatedSteps;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;

        interpolatedSteps = new List<Vector3>();
        Transform previousStep = steps[steps.Count - 1];
        for(var i = 0; i <= steps.Count; i++)
        {
            Transform step = steps[i];

            Transform nextStep = steps[0];
            if (i + 1 < steps.Count)
            {
                nextStep = steps[i + 1];
            }
            var t1 = (step.position - previousStep.position).normalized;
            var t2 = (nextStep.position - step.position).normalized;

            var avgTangent = Vector3.Lerp(t1, t2, 0.5f).normalized;

            interpolatedSteps.Add(step.position - avgTangent);
            interpolatedSteps.Add(step.position + avgTangent);

            previousStep = step;
        }
    }

    void Update()
    {
        if (agent.remainingDistance <= agent.radius)
        {
            currentStep++;
            /*if (currentStep >= steps.Count)
            {
                currentStep = 0;
            }
            agent.destination = steps[currentStep].position;*/
            if (currentStep >= interpolatedSteps.Count)
            {
                currentStep = 0;
            }
            agent.destination = interpolatedSteps[currentStep];
            Debug.Log("new target: " + agent.destination);
        }
        
    }
}
