////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.336.100246-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Reflection;

namespace Albion_Direct
{
    /* Internal type: a2f */
    public partial class FarmableObject : BuildingObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a2f _internal;
        
        #region Properties
        
        public a2f FarmableObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public FarmableObject(a2f instance) : base(instance)
        {
            _internal = instance;
        }
        
        static FarmableObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a2f(FarmableObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FarmableObject(a2f instance)
        {
            return new FarmableObject(instance);
        }
        
        public static implicit operator bool(FarmableObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}