using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using LitJson;
using UnityEditor;
using UnityEngine;

public class AutoBuild : Editor
{
    /// <summary>
    /// ������assetbundle
    /// </summary>
    private static string BundleExportFolder = "Bundles";

    /// <summary>
    /// pc��ios�ɶ�д android ֻ��
    /// </summary>
    private static string BundleExportPath = string.Format("{0}/{1}", ResourceManagerConfig.StreamingAssetsPath, BundleExportFolder);

    /// <summary>
    /// .manifest ����AssetBundlesʱ�����ɵ��嵥�б�
    /// </summary>
    private static string BundleExportPathAux = string.Format("{0}/../BundleManifest", Application.dataPath);

    private static string RESToBuildPath = "Assets/PrefabResources";

    private static List<AssetBundleBuild> ToBuildList = new List<AssetBundleBuild>();


    private static StringBuilder IndexFileContent = new StringBuilder();//·��+prefabResources�ļ����µ�·��
    private static StringBuilder VersionFileContent = new StringBuilder();

    private static JsonData BuildConfig = null;

    private class BuildBundleData
    {
        private AssetBundleBuild _build = new AssetBundleBuild();
        private List<string> _assets = new List<string>();
        private List<string> _addresses = new List<string>();

        public BuildBundleData(string bundleName)
        {
            _build.assetBundleName = bundleName;
        }

        public void AddAsset(string fileName)
        {
            string addressableName = GetAddressableName(fileName);

            _assets.Add(fileName);
            _addresses.Add(addressableName);

            WriteIndexFile(fileName, addressableName);
        }

        public AssetBundleBuild Gen()
        {
            _build.assetNames = _assets.ToArray();
            _build.addressableNames = _addresses.ToArray();

            return _build;
        }
    }

    [MenuItem("Auto Build/Build Bundles")]
    private static void BuildAssetBundle()
    {
        Debug.Log("BuildAssetBundle!");
        BuildConfig = null;

        //��ȡ�汾�ļ�
        //ReadVersionFile();

        //�Ƚ������ļ�·���еľɵ�����ȫ��ɾ��
        if (Directory.Exists(ResourceManagerConfig.StreamingAssetsPath))
        {
            Directory.Delete(ResourceManagerConfig.StreamingAssetsPath, true);
        }
        if (Directory.Exists(BundleExportPath))
        {
            Directory.Delete(BundleExportPath, true);
        }
        if (Directory.Exists(BundleExportPathAux))
        {
            Directory.Delete(BundleExportPathAux, true);
        }

        Directory.CreateDirectory(BundleExportPath);
        Directory.CreateDirectory(BundleExportPathAux);

        ToBuildList.Clear();

        IndexFileContent.Clear();
        VersionFileContent.Clear();

        Dictionary<string, BuildBundleData> bundleDatas = new Dictionary<string, BuildBundleData>();
        Dictionary<string, BuildBundleData> singleBundleDatas = new Dictionary<string, BuildBundleData>();
        List<string> prefixes = new List<string>();

        if (BuildConfig == null)
        {
            string config_path = string.Format("{0}/Configs/buildconfig.txt", Application.dataPath);//�涨��Ҫ������ļ�
            BuildConfig = JsonMapper.ToObject(File.ReadAllText(config_path));
        }
        JsonData bundle_to_gether_round = BuildConfig["bundles_to_gether_round"];
        Debug.Log(BuildConfig["bundles_to_gether_round"]);
        //ͨ��configȥ�Ҷ�Ӧ���ļ���
        foreach (var bundle in bundle_to_gether_round.Keys)
        {
            string folder = bundle;//Assets/PrefabResources/Character/Female/Animation/Cards"
            if (!Directory.Exists(folder))
            {
                Debug.LogError($"build Bundle cannot find dir {folder}");
                continue;
            }

            string prefix = (string)bundle_to_gether_round[bundle];
            if (string.IsNullOrEmpty(prefix))//��Ϊ�յ��Ƿ��Ա�ģ�������
            {
                string bundleName = GetBundleName(folder);
                bundleDatas.Add(folder,new BuildBundleData(bundleName));
            }else
            {
                prefixes.Add(folder + "/" + prefix);
            }
        }

        // ����Assets/PrefabResources·���µ��ļ���      SearchOption.AllDirectories����������Ŀ¼
        string[] files = Directory.GetFiles(RESToBuildPath, "*", SearchOption.AllDirectories);
        for (int n = 0; n < files.Length; n++)
        {
            string file_ext = Path.GetExtension(files[n]);
            if (!CanBundle(file_ext))
            {
                continue;
            }
            string fileName = files[n].Replace("\\", "/");
            string[] names = fileName.Split('/');
            Debug.LogError("====" +names.Length+"==========="+ fileName);
            if (names.Length < 4)
            {
                //Assets/PrefabResources/index.txt
                Debug.Log($"gen build bunld skip file {fileName}");
                continue;
            }

            ///////////////////////////////////������Ҫ�������
            ///�������ݰ��ļ��д��
            ///




            

        }

        foreach (var item in bundleDatas.Values)
        {
            ToBuildList.Add(item.Gen());
        }
        foreach (var item in singleBundleDatas.Values)
        {
            ToBuildList.Add(item.Gen());
        }

        BuildScenes();

        {
            //Assets/PrefabResources/index.txt
            string index_file_path = string.Format("{0}{1}.txt", RESToBuildPath, ResourceManagerConfig.kIndexFileName);
            File.WriteAllText(index_file_path, IndexFileContent.ToString());

        }

    }

    private static bool CanBundle(string ext)
    {
        if (ext == ".meta")
        {
            return false;
        }
        return true;
    }

    private static MD5 md5 = new MD5CryptoServiceProvider();
    private static string GetBundleName(string path)
    {
        return ResourceManagerConfig.FormatString("{0}.assetbundle",AssetDatabase.AssetPathToGUID(path));
        //MD5 ����
        //byte[] md5Byte = md5.ComputeHash(Encoding.Default.GetBytes(path));
        //string str = GetMD5(md5Byte) + ".assetbundle";
        //return str;
    }

    private static string GetMD5(byte[] retVal)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < retVal.Length; i++)
        {
            sb.Append(retVal[i].ToString("x2"));//ת����Сд��16���� �����λ������Ĳ�0
        }
        return sb.ToString();
    }

    private static string GetAddressableName(string file_path)
    {
        string addressable_name = file_path;
        addressable_name = addressable_name.Replace(RESToBuildPath, "");

        int dot_pos = addressable_name.LastIndexOf('.');
        if (dot_pos != -1)
        {
            int count = addressable_name.Length - dot_pos;
            addressable_name = addressable_name.Remove(dot_pos, count);
        }
        return addressable_name;
    }

    private static void WriteIndexFile(string key,string value)
    {
        IndexFileContent.AppendFormat("{0}:{1}", key, value);
        IndexFileContent.AppendLine();
    }

    private static void BuildScenes()
    {
        string[] scenes = GetBuildScenes(true);
    }

    private static string[] GetBuildScenes(bool bundle)
    {
        List<string> scenes = new List<string>();

        return scenes.ToArray();
    }
}
