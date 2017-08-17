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
    /* Internal type: ar2 */
    public class EquipmentItemObject : DurableItemObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private ar2 _internal;
        
        #region Properties
        
        public ar2 EquipmentItemObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public EquipmentItemObject(ar2 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static EquipmentItemObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ar2(EquipmentItemObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator EquipmentItemObject(ar2 instance)
        {
            return new EquipmentItemObject(instance);
        }
        
        #endregion
    }
}
