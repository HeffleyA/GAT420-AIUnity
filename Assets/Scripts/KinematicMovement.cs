using UnityEngine;

public class KinematicMovement : Movement
{
    public override void ApplyForce(Vector3 force)
    {
        Accerlation += force;
    }

    private void LateUpdate()
    {
        Velocity += Accerlation * Time.deltaTime;
        Velocity = Vector3.ClampMagnitude(Velocity, data.maxSpeed);

        transform.position += Velocity * Time.deltaTime;
        Accerlation = Vector3.zero;
    }
}
