using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float HorizontalSpeedMultiplier = 2f;
    public float VerticalSpeedMultiplier = 2f;

    public float HorizontalSprintSpeedMultiplier = 4f;
    public float VerticalSprintSpeedMultiplier = 4f;

    public bool CanSprint;
    public KeyCode SprintKey = KeyCode.LeftShift;

    private void Update()
    {
        if(CanSprint)
        {
            if (Input.GetKey(SprintKey))
            {
                transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * HorizontalSprintSpeedMultiplier);
                transform.Translate(Vector3.up * Input.GetAxis("Vertical") * Time.deltaTime * VerticalSprintSpeedMultiplier);
            }
            else
            {
                transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * HorizontalSpeedMultiplier);
                transform.Translate(Vector3.up * Input.GetAxis("Vertical") * Time.deltaTime * VerticalSpeedMultiplier);
            }
        }
        else
        {
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * HorizontalSpeedMultiplier);
            transform.Translate(Vector3.up * Input.GetAxis("Vertical") * Time.deltaTime * VerticalSpeedMultiplier);
        }
    }
}
