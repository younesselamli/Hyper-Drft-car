using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowCar : MonoBehaviour
{

    [Header("Shake Settings")]
    public float duration = 1f;
    public CarManager triggerEnter;
    [Header ("CameraFollow")]
    [SerializeField] Transform player;
    [SerializeField] Vector3 offSet;

    private void Start()
    {
        triggerEnter.GetComponent<CarController>();
    }
    public IEnumerator Shaking()
    {
        Vector3 startposition = transform.position;
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            elapsedTime = +Time.fixedDeltaTime;
            transform.position = startposition + Random.insideUnitSphere;
            yield return null;
        }
        transform.position = startposition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.position + offSet;
        if (triggerEnter.isFinish == true)
        {
            StartCoroutine(Shaking());
        }
    }
}
