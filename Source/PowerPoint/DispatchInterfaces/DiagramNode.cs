using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface DiagramNode 
	/// SupportByVersion PowerPoint, 10,11,12,14
	///</summary>
	[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DiagramNode : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(DiagramNode);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public object Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.DiagramNodeChildren Children
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Children", paramsArray);
				NetOffice.PowerPointApi.DiagramNodeChildren newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.DiagramNodeChildren.LateBindingApiWrapperType) as NetOffice.PowerPointApi.DiagramNodeChildren;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Shape Shape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shape", paramsArray);
				NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.DiagramNode Root
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Root", paramsArray);
				NetOffice.PowerPointApi.DiagramNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.DiagramNode.LateBindingApiWrapperType) as NetOffice.PowerPointApi.DiagramNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Diagram Diagram
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Diagram", paramsArray);
				NetOffice.PowerPointApi.Diagram newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Diagram.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Diagram;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoOrgChartLayoutType Layout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Layout", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoOrgChartLayoutType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Layout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Shape TextShape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextShape", paramsArray);
				NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="pos">optional NetOffice.OfficeApi.Enums.MsoRelativeNodePosition Pos = 2</param>
		/// <param name="nodeType">optional NetOffice.OfficeApi.Enums.MsoDiagramNodeType NodeType = 1</param>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.DiagramNode AddNode(NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos, NetOffice.OfficeApi.Enums.MsoDiagramNodeType nodeType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pos, nodeType);
			object returnItem = Invoker.MethodReturn(this, "AddNode", paramsArray);
			NetOffice.PowerPointApi.DiagramNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.DiagramNode.LateBindingApiWrapperType) as NetOffice.PowerPointApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.DiagramNode AddNode()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddNode", paramsArray);
			NetOffice.PowerPointApi.DiagramNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.DiagramNode.LateBindingApiWrapperType) as NetOffice.PowerPointApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="pos">optional NetOffice.OfficeApi.Enums.MsoRelativeNodePosition Pos = 2</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.DiagramNode AddNode(NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pos);
			object returnItem = Invoker.MethodReturn(this, "AddNode", paramsArray);
			NetOffice.PowerPointApi.DiagramNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.DiagramNode.LateBindingApiWrapperType) as NetOffice.PowerPointApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="targetNode">NetOffice.PowerPointApi.DiagramNode TargetNode</param>
		/// <param name="pos">NetOffice.OfficeApi.Enums.MsoRelativeNodePosition Pos</param>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public void MoveNode(NetOffice.PowerPointApi.DiagramNode targetNode, NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetNode, pos);
			Invoker.Method(this, "MoveNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="targetNode">NetOffice.PowerPointApi.DiagramNode TargetNode</param>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public void ReplaceNode(NetOffice.PowerPointApi.DiagramNode targetNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetNode);
			Invoker.Method(this, "ReplaceNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="targetNode">NetOffice.PowerPointApi.DiagramNode TargetNode</param>
		/// <param name="swapChildren">optional bool SwapChildren = true</param>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public void SwapNode(NetOffice.PowerPointApi.DiagramNode targetNode, bool swapChildren)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetNode, swapChildren);
			Invoker.Method(this, "SwapNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="targetNode">NetOffice.PowerPointApi.DiagramNode TargetNode</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public void SwapNode(NetOffice.PowerPointApi.DiagramNode targetNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetNode);
			Invoker.Method(this, "SwapNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="copyChildren">bool CopyChildren</param>
		/// <param name="targetNode">NetOffice.PowerPointApi.DiagramNode TargetNode</param>
		/// <param name="pos">optional NetOffice.OfficeApi.Enums.MsoRelativeNodePosition Pos = 2</param>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.DiagramNode CloneNode(bool copyChildren, NetOffice.PowerPointApi.DiagramNode targetNode, NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(copyChildren, targetNode, pos);
			object returnItem = Invoker.MethodReturn(this, "CloneNode", paramsArray);
			NetOffice.PowerPointApi.DiagramNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.DiagramNode.LateBindingApiWrapperType) as NetOffice.PowerPointApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="copyChildren">bool CopyChildren</param>
		/// <param name="targetNode">NetOffice.PowerPointApi.DiagramNode TargetNode</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.DiagramNode CloneNode(bool copyChildren, NetOffice.PowerPointApi.DiagramNode targetNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(copyChildren, targetNode);
			object returnItem = Invoker.MethodReturn(this, "CloneNode", paramsArray);
			NetOffice.PowerPointApi.DiagramNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.DiagramNode.LateBindingApiWrapperType) as NetOffice.PowerPointApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="receivingNode">NetOffice.PowerPointApi.DiagramNode ReceivingNode</param>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public void TransferChildren(NetOffice.PowerPointApi.DiagramNode receivingNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(receivingNode);
			Invoker.Method(this, "TransferChildren", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.DiagramNode NextNode()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "NextNode", paramsArray);
			NetOffice.PowerPointApi.DiagramNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.DiagramNode.LateBindingApiWrapperType) as NetOffice.PowerPointApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.DiagramNode PrevNode()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "PrevNode", paramsArray);
			NetOffice.PowerPointApi.DiagramNode newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.DiagramNode.LateBindingApiWrapperType) as NetOffice.PowerPointApi.DiagramNode;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}