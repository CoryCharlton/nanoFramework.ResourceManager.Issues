//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PositiveResourceIds
{
    
    internal partial class Resource2
    {
        private static System.Resources.ResourceManager manager;
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if ((Resource2.manager == null))
                {
                    Resource2.manager = new System.Resources.ResourceManager("PositiveResourceIds.Resource2", typeof(Resource2).Assembly);
                }
                return Resource2.manager;
            }
        }
        internal static string GetString(Resource2.StringResources id)
        {
            return ((string)(nanoFramework.Runtime.Native.ResourceUtility.GetObject(ResourceManager, id)));
        }
        [System.SerializableAttribute()]
        internal enum StringResources : short
        {
            StringPositiveId = 12314,
        }
    }
}
