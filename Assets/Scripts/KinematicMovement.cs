using UnityEngine;

public class KinematicMovement : Movement
{
    public override void ApplyForce(Vector3 force)
    {
        Accerlation += force;
    }

    public override void MoveTowards(Vector3 position)
    {
        Vector3 direction = position - transform.position;
        ApplyForce(direction.normalized * data.maxForce);
    }

    private void LateUpdate()
    {
        Velocity += Accerlation * Time.deltaTime;
        Velocity = Vector3.ClampMagnitude(Velocity, data.maxSpeed);

        transform.position += Velocity * Time.deltaTime;
        Accerlation = Vector3.zero;
    }
}
