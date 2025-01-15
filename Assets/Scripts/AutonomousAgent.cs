using UnityEngine;

public class AutonomousAgent : AIAgent
{
    public Perception perception;

    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * perception.maxDistance, Color.cyan);

        var gameObjects = perception.GetGameObjects();
        foreach (var go in gameObjects)
        {
            Debug.DrawLine(transform.position, go.transform.position, Color.magenta);
        }
    }
}
