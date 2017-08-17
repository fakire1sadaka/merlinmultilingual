////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.94396-live
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Merlin.API.Direct
{
    /* Internal type: ar6 */
    public class FurnitureItemObject : DurableItemObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private ar6 _internal;
        
        #region Properties
        
        public ar6 FurnitureItemObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public FurnitureItemObject(ar6 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static FurnitureItemObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ar6(FurnitureItemObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FurnitureItemObject(ar6 instance)
        {
            return new FurnitureItemObject(instance);
        }
        
        #endregion
    }
}
