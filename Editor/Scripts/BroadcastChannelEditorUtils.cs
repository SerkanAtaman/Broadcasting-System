using UnityEditor;

namespace SeroJob.BroadcastingSystem.Editor
{
    public static class BroadcastChannelEditorUtils
    {
        private static readonly string _templatePath = "Packages/com.serojob.broadcasting/Editor/ScriptTemplates/82-BroadcastChannel-NewBroadcastChannel.cs.txt";

        [MenuItem(itemName: "Assets/Create/SeroJob/Broadcasting/NewBroadcastChannel", isValidateFunction: false, priority: 51)]
        public static void CreateNewBroadcastChannel()
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(_templatePath, "NewBroadcastChannel.cs");
        }
    }
}
