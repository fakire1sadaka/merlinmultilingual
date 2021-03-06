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
    /* Internal type: ajg */
    public class Point2
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private ajg _internal;
        
        #region Properties
        
        public ajg Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public float GetX() => _internal.g();
        public float GetY() => _internal.h();
        public float[] ToArray() => _internal.i();
        
        #endregion
        
        #region Constructor
        
        public Point2(ajg instance)
        {
            _internal = instance;
        }
        
        static Point2()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ajg(Point2 instance)
        {
            return instance._internal;
        }
        
        public static implicit operator Point2(ajg instance)
        {
            return new Point2(instance);
        }
        
        #endregion
    }
}
