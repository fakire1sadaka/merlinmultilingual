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
    /* Internal type: ars */
    public class DurableItemObject : ItemObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private ars _internal;
        
        #region Properties
        
        public ars DurableItemObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public DurableItemObject(ars instance) : base(instance)
        {
            _internal = instance;
        }
        
        static DurableItemObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ars(DurableItemObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator DurableItemObject(ars instance)
        {
            return new DurableItemObject(instance);
        }
        
        #endregion
    }
}
