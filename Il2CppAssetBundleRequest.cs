using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
    public class AssetBundleCreateRequest : AsyncOperation
    {
        public AssetBundleCreateRequest(IntPtr ptr) : base(ptr) { }

        public Il2CppAssetBundle assetBundle
        {
            get
            {

            }
        }
    }

    public class AssetBundleRequest : AsyncOperation
    {
        public AssetBundleRequest(IntPtr ptr) : base(ptr) { }

        public UnityEngine.Object asset
        {
            get
            {

            }
        }

        public UnityEngine.Object[] allAssets
        {
            get
            {

            }
        }
    }
}