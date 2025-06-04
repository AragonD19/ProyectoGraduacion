using UnityEngine;
using Unity.MLAgents;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var agent = collision.GetComponent<PuzzleAgent>();
            agent.SetReward(1f);
            agent.EndEpisode();
        }
    }
}
