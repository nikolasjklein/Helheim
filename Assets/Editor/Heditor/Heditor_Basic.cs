using UnityEngine;
using UnityEditor;

public class Heditor_Basic : EditorWindow
{
    public string buddyText;
    public float duration;
    public Sprite inspectionObject;
    public string listName;
    public bool isRelevantEvidence;
    public bool isTriggeredByTrigger;
    public bool isTriggeredByClick;

    public bool showHelp;

    [MenuItem("Heditor/Basic")]

    public static void ShowWindow()
    {
        EditorWindow.GetWindow<Heditor_Basic>("Heditor Basic");
    }

    private void OnGUI()
    {
        Texture2D logo = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/heditor_basic.png", typeof(Texture2D));
        GUILayout.Label(logo);

        GUILayout.BeginVertical();
        GUILayout.Label("------------------------------------------------------------------------------------------------------", EditorStyles.largeLabel);
        GUILayout.EndVertical();

        showHelp = EditorGUILayout.Foldout(showHelp, "Help");

        if (showHelp)
        {
            GUILayout.Label("This is the HELP for the Heditor Suite:\nOver time, more and more different Editors will be developed to help development on Project: Helheim.\n\nThese currently indluce:\n" +
                "- Debug Log Check (initializing the Debug Log and checking\n   its functionality)\n" +
                "- Basic (what you are looking at right now)\n" +
                "- Prop Editor (giving Designers the tool to change Assets\n   and their texture within the scene)", EditorStyles.helpBox);
        }

        /*
        //GUILayout.Label("INSPECTION DIALOGUE EDITOR", EditorStyles.helpBox);
        GUILayout.BeginVertical();
        GUILayout.Label("Set the Display Image of the Item:\n(as a Sprite File!)", EditorStyles.boldLabel);
        inspectionObject = (Sprite)EditorGUILayout.ObjectField("", inspectionObject, typeof(Sprite), false);
        GUILayout.EndVertical();

        //
        GUILayout.BeginVertical();
        GUILayout.Label("");
        GUILayout.Label("Set Text that the Player says upon Inspection:", EditorStyles.boldLabel);
        buddyText = EditorGUILayout.TextField("", buddyText);
        GUILayout.EndVertical();

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

                //relevant for toggling how it is triggered
                if (isTriggeredByClick)
                {
                    //npc.GetComponent<Heditor_Basic>().useTriggerEnter = false;
                    //npc.GetComponent<Heditor_Basic>().useOnClick = true;
                }

                if (isTriggeredByTrigger)
                {
                    //npc.GetComponent<Heditor_Basic>().useTriggerEnter = true;
                    //npc.GetComponent<Heditor_Basic>().useOnClick = false;
                }
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
