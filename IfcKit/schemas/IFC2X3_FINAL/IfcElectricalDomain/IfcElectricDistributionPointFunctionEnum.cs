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
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcSharedBldgServiceElements;

namespace BuildingSmart.IFC.IfcElectricalDomain
{
	[Guid("db2aa3d1-6ec8-4168-925f-ba81cc179f92")]
	public enum IfcElectricDistributionPointFunctionEnum
	{
		ALARMPANEL = 1,
	
		CONSUMERUNIT = 2,
	
		CONTROLPANEL = 3,
	
		DISTRIBUTIONBOARD = 4,
	
		GASDETECTORPANEL = 5,
	
		INDICATORPANEL = 6,
	
		MIMICPANEL = 7,
	
		MOTORCONTROLCENTRE = 8,
	
		SWITCHBOARD = 9,
	
		USERDEFINED = -1,
	
		NOTDEFINED = 0,
	
	}
}
