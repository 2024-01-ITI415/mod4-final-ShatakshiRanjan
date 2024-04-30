using UnityEngine;

public class CanvasPanelController : MonoBehaviour
{
    public GameObject panel; // Reference to the canvas panel object

    private bool panelVisible = false; // Flag to track panel visibility

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TogglePanelVisibility();
        }
    }

    void TogglePanelVisibility()
    {
        panelVisible = !panelVisible; // Toggle the visibility flag

        // Set the panel's active state based on the visibility flag
        panel.SetActive(panelVisible);
    }
}
