// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcStructuralLoadResource
{
	[Guid("640a9d71-ce83-4f2d-933d-d0f1a5fb00b5")]
	public partial class IfcStructuralLoadSingleForce : IfcStructuralLoadStatic
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcForceMeasure? _ForceX;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcForceMeasure? _ForceY;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcForceMeasure? _ForceZ;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		IfcTorqueMeasure? _MomentX;
	
		[DataMember(Order=4)] 
		[XmlAttribute]
		IfcTorqueMeasure? _MomentY;
	
		[DataMember(Order=5)] 
		[XmlAttribute]
		IfcTorqueMeasure? _MomentZ;
	
	
		[Description("Force value in x-direction. ")]
		public IfcForceMeasure? ForceX { get { return this._ForceX; } set { this._ForceX = value;} }
	
		[Description("Force value in y-direction.")]
		public IfcForceMeasure? ForceY { get { return this._ForceY; } set { this._ForceY = value;} }
	
		[Description("Force value in z-direction.")]
		public IfcForceMeasure? ForceZ { get { return this._ForceZ; } set { this._ForceZ = value;} }
	
		[Description("Moment about the x-axis.")]
		public IfcTorqueMeasure? MomentX { get { return this._MomentX; } set { this._MomentX = value;} }
	
		[Description("Moment about the y-axis.")]
		public IfcTorqueMeasure? MomentY { get { return this._MomentY; } set { this._MomentY = value;} }
	
		[Description("Moment about the z-axis.")]
		public IfcTorqueMeasure? MomentZ { get { return this._MomentZ; } set { this._MomentZ = value;} }
	
	
	}
	
}
