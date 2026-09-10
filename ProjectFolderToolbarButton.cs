using UnityEditor;
using UnityEditor.Toolbars;
using UnityEngine;

public class MainToolbarOpenProjectFolderButton
{
    [MainToolbarElement("Project/Project Folder", defaultDockPosition = MainToolbarDockPosition.Left)]
    public static MainToolbarElement ProjectFolderButton()
    {
        Texture2D icon = EditorGUIUtility.IconContent("d_Folder Icon").image as Texture2D;

        MainToolbarContent content = new("Project Folder", icon, "Open project folder");

        return new MainToolbarButton(content, () => EditorUtility.RevealInFinder(Application.dataPath));    
    }
}

