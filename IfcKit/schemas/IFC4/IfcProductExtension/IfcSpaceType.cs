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

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMaterialResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPropertyResource;
using BuildingSmart.IFC.IfcQuantityResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcSharedBldgElements;
using BuildingSmart.IFC.IfcSharedBldgServiceElements;
using BuildingSmart.IFC.IfcSharedComponentElements;
using BuildingSmart.IFC.IfcSharedFacilitiesElements;
using BuildingSmart.IFC.IfcStructuralElementsDomain;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("e7fcbf9c-f9a1-43ab-b15f-56f0e33af740")]
	public partial class IfcSpaceType : IfcSpatialStructureElementType
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcSpaceTypeEnum _PredefinedType;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcLabel? _LongName;
	
	
		[Description("<EPM-HTML>\r\nPredefined types to define the particular type of space. There may be" +
	    " property set definitions available for each predefined type.\r\n</EPM-HTML>")]
		public IfcSpaceTypeEnum PredefinedType { get { return this._PredefinedType; } set { this._PredefinedType = value;} }
	
		[Description(@"<EPM-HTML>
	Long name for a space type, used for informal purposes. It should be used, if available, in conjunction with the inherited <em>Name</em> attribute.
	<blockquote class=""note"">
	  NOTE&nbsp; In many scenarios the <em>Name</em> attribute refers to the short name or number of a space type, and the <em>LongName</em> refers to the full descriptive name.
	</blockquote>
	<blockquote class=""change-ifc2x4"">
	  IFC4 CHANGE&nbsp; New attribute added at the end of entity definition.
	</blockquote>
	</EPM-HTML>")]
		public IfcLabel? LongName { get { return this._LongName; } set { this._LongName = value;} }
	
	
	}
	
}