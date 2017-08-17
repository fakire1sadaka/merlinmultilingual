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
    /* Internal type: arx */
    public class ConsumableItemProxy : SimpleItemProxy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private arx _internal;
        
        #region Properties
        
        public arx ConsumableItemProxy_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ConsumableItemProxy(arx instance) : base(instance)
        {
            _internal = instance;
        }
        
        static ConsumableItemProxy()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator arx(ConsumableItemProxy instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ConsumableItemProxy(arx instance)
        {
            return new ConsumableItemProxy(instance);
        }
        
        #endregion
    }
}
