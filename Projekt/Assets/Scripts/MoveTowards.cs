using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] int speed = 1;
    Vector3 playerPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
}
