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

using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationResource;
using BuildingSmart.IFC.IfcRepresentationResource;

namespace BuildingSmart.IFC.IfcPresentationOrganizationResource
{
	[Guid("0ff83e6c-fe39-4dda-8358-567127e601d7")]
	public partial class IfcPresentationLayerAssignment
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcLabel _Name;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcText? _Description;
	
		[DataMember(Order=2)] 
		[Required()]
		ISet<IfcLayeredItem> _AssignedItems = new HashSet<IfcLayeredItem>();
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		IfcIdentifier? _Identifier;
	
	
		[Description("Name of the layer.")]
		public IfcLabel Name { get { return this._Name; } set { this._Name = value;} }
	
		[Description("Additional description of the layer.")]
		public IfcText? Description { get { return this._Description; } set { this._Description = value;} }
	
		[Description("The set of layered items, which are assigned to this layer.")]
		public ISet<IfcLayeredItem> AssignedItems { get { return this._AssignedItems; } }
	
		[Description("An (internal) identifier assigned to the layer.")]
		public IfcIdentifier? Identifier { get { return this._Identifier; } set { this._Identifier = value;} }
	
	
	}
	
}
