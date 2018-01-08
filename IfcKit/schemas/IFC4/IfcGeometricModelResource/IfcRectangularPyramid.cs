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

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcProfileResource;
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("1ad16494-b844-40aa-bd8c-42b28ea6cf30")]
	public partial class IfcRectangularPyramid : IfcCsgPrimitive3D
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcPositiveLengthMeasure _XLength;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcPositiveLengthMeasure _YLength;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		[Required()]
		IfcPositiveLengthMeasure _Height;
	
	
		[Description("<EPM-HTML>\r\nThe length of the base measured along the placement X axis. It is pro" +
	    "vided by the inherited axis placement through <em>SELF\\IfcCsgPrimitive3D.Positio" +
	    "n.P[1]</em>.\r\n</EPM-HTML>")]
		public IfcPositiveLengthMeasure XLength { get { return this._XLength; } set { this._XLength = value;} }
	
		[Description("<EPM-HTML>\r\nThe length of the base measured along the placement Y axis. It is pro" +
	    "vided by the inherited axis placement through <em>SELF\\IfcCsgPrimitive3D.Positio" +
	    "n.P[2]</em>.\r\n</EPM-HTML>")]
		public IfcPositiveLengthMeasure YLength { get { return this._YLength; } set { this._YLength = value;} }
	
		[Description("<EPM-HTML>\r\nThe height of the apex above the plane of the base, measured in the d" +
	    "irection of the placement Z axis, the <em>SELF\\IfcCsgPrimitive3D.Position.P[2]</" +
	    "em>.\r\n</EPM-HTML>")]
		public IfcPositiveLengthMeasure Height { get { return this._Height; } set { this._Height = value;} }
	
	
	}
	
}