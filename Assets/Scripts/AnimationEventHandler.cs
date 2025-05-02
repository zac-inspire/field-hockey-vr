using UnityEngine;

public class AnimationEventHandler : MonoBehaviour
{
    public GameObject objectToDisable;

    // This function must match the event signature
    public void DisableObject()
    {
        if (objectToDisable != null)
        {
            objectToDisable.SetActive(false);
        }
    }

    // Optional: Reset the object after each loop if needed
    public void EnableObject()
    {
        if (objectToDisable != null)
        {
            objectToDisable.SetActive(true);
        }
    }
}
