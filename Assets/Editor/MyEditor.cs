using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;

public class MyEditor : Editor
{
    private static AddressableAssetSettings setting = AssetDatabase.LoadAssetAtPath<AddressableAssetSettings>("Assets/AddressableAssetsData/AddressableAssetSettings.asset");

    [MenuItem("����/����AA����")]
    public static void UpdateAAGroups()
    {
        string productsDir = $"{Application.dataPath}/";
        DirectoryInfo dirInfo = new DirectoryInfo(productsDir);

        foreach (var item in dirInfo.GetDirectories())
        {
            CreateGroup(item );   
        }
    }

    private static void CreateGroup(DirectoryInfo dirInfo)
    {
        string groupName = dirInfo.Name;
        AddressableAssetGroup group = FindGroup(groupName);
        if (group == null)
        {
            //����group
            group = setting.CreateGroup(groupName, false, false, true, new List<AddressableAssetGroupSchema>());
        }

        //��Ӹ��²���
        //��Ӵ������
        //��ָ��Ŀ¼�µ��ļ�����Ŀ¼��ӵ����鵱��
        
    }

    private static AddressableAssetGroup FindGroup(string groupName)
    {
        return null;
    }
}
