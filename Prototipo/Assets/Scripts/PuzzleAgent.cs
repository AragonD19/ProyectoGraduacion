using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;
using UnityEngine;

public class PuzzleAgent : Agent
{
    public Transform goal;
    private Rigidbody2D rb;
    public float moveSpeed = 3f;

    public override void Initialize()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public override void OnEpisodeBegin()
    {
        transform.localPosition = new Vector2(Random.Range(-7f, 7f), Random.Range(-4f, 4f));
        goal.localPosition = new Vector2(Random.Range(-7f, 7f), Random.Range(-4f, 4f));
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.localPosition);
        sensor.AddObservation(goal.localPosition);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        Vector2 move = new Vector2(actions.ContinuousActions[0], actions.ContinuousActions[1]);
        rb.linearVelocity = move * moveSpeed;

        float distance = Vector2.Distance(transform.localPosition, goal.localPosition);
        if (distance < 0.5f)
        {
            SetReward(1f);
            EndEpisode();
        }
        if (transform.localPosition.y < -5 || transform.localPosition.y > 5 || 
            transform.localPosition.x < -5 || transform.localPosition.x > 5)
        {
            SetReward(-1.0f);
            EndEpisode();
        }
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        var act = actionsOut.ContinuousActions;
        act[0] = Input.GetAxisRaw("Horizontal");
        act[1] = Input.GetAxisRaw("Vertical");
    }
}
