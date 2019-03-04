using UnityEngine;
using UnityEditor;

public class Heditor_PropEditor : EditorWindow
{
    public Mesh editorGo;
    public Texture editorTex;

    public int goCount = 0;
    public int texCount = 0;

    public string goName;

    [MenuItem("Heditor/Prop Editor")]

    public static void ShowWindow()
    {
        EditorWindow.GetWindow<Heditor_PropEditor>("Heditor Prop Editor");
        EditorWindow.GetWindow(typeof(ChangeableMesh));
    }

    private void OnGUI()
    {
        ChangeableMesh component;

        Texture2D logo = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/heditor_basic.png", typeof(Texture2D));
        GUILayout.Label(logo);

        GUILayout.BeginVertical();
        GUILayout.Label("------------------------------------------------------------------------------------------------------", EditorStyles.largeLabel);
        GUILayout.EndVertical();

        GUILayout.BeginVertical();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Object Mesh:", EditorStyles.boldLabel);
        GUILayout.Label(goName, EditorStyles.helpBox);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("");
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("<"))
        {
            foreach (GameObject gO in Selection.gameObjects)
            {
                goCount = goCount - 1;

                if (goCount == 0)
                {
                    goName = "Blockout Block";
                    gO.GetComponent<ChangeableMesh>().go = gO.GetComponent<ChangeableMesh>().GameObjects[0];
                }

                if (goCount == 1)
                {
                    goName = "Arm";
                    gO.GetComponent<ChangeableMesh>().go = gO.GetComponent<ChangeableMesh>().GameObjects[1];
                }

                Debug.Log(goCount);
            }
        }

        if (GUILayout.Button(">"))
        {
            foreach (GameObject gO in Selection.gameObjects)
            {
                goCount = goCount + 1;

                if (goCount == 0)
                {
                    goName = "Blockout Block";
                    gO.GetComponent<ChangeableMesh>().go = gO.GetComponent<ChangeableMesh>().GameObjects[0];
                }

                if (goCount == 1)
                {
                    goName = "Arm";
                    gO.GetComponent<ChangeableMesh>().go = gO.GetComponent<ChangeableMesh>().GameObjects[1];
                }

                Debug.Log(goCount);
            }
        }

        GUILayout.EndHorizontal();

        GUILayout.EndVertical();

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        GUILayout.BeginVertical();
        GUILayout.Label("");
        GUILayout.Label("");
        GUILayout.EndVertical();

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        GUILayout.BeginVertical();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Object Texture:", EditorStyles.boldLabel);
        GUILayout.Label("Texture Name", EditorStyles.helpBox);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("");
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("<"))
        {
            
        }

        if (GUILayout.Button(">"))
        {

        }

        GUILayout.EndHorizontal();

        GUILayout.EndVertical();

        /*
        //
        GUILayout.BeginVertical();
        GUILayout.Label("");
        GUILayout.Label("Set how long the Panel should be displayed for:\n(in Seconds!)", EditorStyles.boldLabel);
        duration = EditorGUILayout.FloatField("", duration);
        GUILayout.EndVertical();

        //
        GUILayout.BeginVertical();
        GUILayout.Label("");
        GUILayout.Label("Set whether or not this Item is relevant Evidence:\n(this will decide if it is added to the later Dialogue Dropdown!)", EditorStyles.boldLabel);
        isRelevantEvidence = EditorGUILayout.Toggle("is Relevant Evidence", isRelevantEvidence);
        GUILayout.EndVertical();

        //
        GUILayout.BeginVertical();
        GUILayout.Label("");
        GUILayout.Label("Set the Name of the Item which should get added\nas Evidence:\n(only in ALL-CAPS!)", EditorStyles.boldLabel);
        listName = EditorGUILayout.TextField("", listName);
        GUILayout.EndVertical();

        //
        GUILayout.BeginVertical();
        GUILayout.Label("");
        GUILayout.Label("Toggle how this Inspection will be triggered:\n(please tick only one!)", EditorStyles.boldLabel);
        isTriggeredByTrigger = EditorGUILayout.Toggle("is Triggered by Trigger", isTriggeredByTrigger);
        isTriggeredByClick = EditorGUILayout.Toggle("is Triggered by Click", isTriggeredByClick);
        GUILayout.EndVertical();

        //---------------------------------------------------------------------------------------------------------------------------------------
        GUILayout.Label("");
        if (GUILayout.Button("Apply"))
        {
            Debug.Log("Applied");

            foreach (GameObject npc in Selection.gameObjects)
            {
                //relevant for the image that is being displayed
                //npc.GetComponent<Heditor_Basic>().InspectionObject = inspectionObject;

                //relevant for toggling the text that the player says upon inspection
                //npc.GetComponent<Heditor_Basic>().BuddyText = buddyText;

                //relevant for toggling how long the canvas should be shown
                //npc.GetComponent<Heditor_Basic>().sec = duration;

                //relevant for toggling if the item is relevant
                if (isRelevantEvidence)
                {
                    //npc.GetComponent<Heditor_Basic>().isEvidenceRelevant = true;
                }

                //relevant for the name of the list item
                //npc.GetComponent<Heditor_Basic>().Dialogue_ListName = listName;
            }
        }

        showHelp = EditorGUILayout.Foldout(showHelp, "Help");

        if (showHelp)
        {
            GUILayout.Label("This is the HELP for the Inspection Dialogue Editor:\nTo actually" +
                "change in -game values, change the parameters,\nselect the 'NPC // ___' and last," +
                "click 'Apply' in this\nwindow.", EditorStyles.helpBox);
        }
        */
    }
}
