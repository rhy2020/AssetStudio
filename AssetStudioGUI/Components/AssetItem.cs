using System.Windows.Forms;
using AssetStudio;

namespace AssetStudioGUI
{
    internal class AssetItem : ListViewItem
    {
        public Object Asset;
        public SerializedFile SourceFile;
        public string Container = string.Empty;
        public string TypeString;
        public long m_PathID;
        public long FullSize;
        public ClassIDType Type;
        public string InfoText;
        public string UniqueID;
        public GameObjectTreeNode TreeNode;
        public string ABFileName;

        public AssetItem(Object asset)
        {
            Asset = asset;
            SourceFile = asset.assetsFile;
            ABFileName = SourceFile.originalPath.Substring(SourceFile.originalPath.LastIndexOf("\\") + 1);
            Type = asset.type;
            TypeString = Type.ToString();
            m_PathID = asset.m_PathID;
            FullSize = asset.byteSize;
        }

        public void SetSubItems()
        {
            SubItems.AddRange(new[]
            {
                Container, //Container
                TypeString, //Type
                m_PathID.ToString(), //PathID
                FullSize.ToString(), //Size
                ABFileName, //Belong Target AssetBundle File
            });
        }
    }
}
