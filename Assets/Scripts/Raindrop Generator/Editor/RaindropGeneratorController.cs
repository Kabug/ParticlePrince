using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RaindropGenerator))]
public class RaindropGeneratorController : Editor
{
    private string ButtonVal = "Erode Terrain";
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        RaindropGenerator raindropGen = (RaindropGenerator)target;
        if (GUILayout.Button(ButtonVal))
        {
            if (ButtonVal == "Erode Terrain")
            {
                ButtonVal = "Pause Erosion";
            }
            else
            {
                ButtonVal = "Erode Terrain";
            }
            raindropGen.toggleErosion();
        }
    }
}
