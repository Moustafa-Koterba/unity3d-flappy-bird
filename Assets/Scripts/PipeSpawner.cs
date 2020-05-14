using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;

    public float minTime = 1f;
    public float maxTime = 2f;
    public float height;

    private float timer = 0f;
    private bool launch;

    public void Launch()
    {
        launch = true;
    }

    void Update()
    {
        if (!launch)
        {
            return;
        }

        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height));
            Destroy(newPipe, 7);
            timer = 0f;

            if (maxTime > minTime)
            {
                maxTime -= 0.01f;
            }
        }

        timer += Time.deltaTime;
    }
}
