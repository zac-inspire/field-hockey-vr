using System.Collections;
using UnityEngine;

public class DelayedActivator : MonoBehaviour
{
    [Header("Objects to Activate")]
    public GameObject[] objectsToActivate;

    [Header("Objects to Deactivate")]
    public GameObject[] objectsToDeactivate;

    [Header("Delay Settings")]
    public float delayInSeconds = 2f;

    private void Start()
    {
        StartCoroutine(ActivateDeactivateAfterDelay());
    }

    private IEnumerator ActivateDeactivateAfterDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);

        foreach (GameObject obj in objectsToActivate)
        {
            if (obj != null)
                obj.SetActive(true);
        }

        foreach (GameObject obj in objectsToDeactivate)
        {
            if (obj != null)
                obj.SetActive(false);
        }
    }
}
