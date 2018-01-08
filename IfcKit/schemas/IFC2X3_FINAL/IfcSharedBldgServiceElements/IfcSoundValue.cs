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
using BuildingSmart.IFC.IfcControlExtension;
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMaterialPropertyResource;
using BuildingSmart.IFC.IfcMaterialResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcProfileResource;
using BuildingSmart.IFC.IfcPropertyResource;
using BuildingSmart.IFC.IfcTimeSeriesResource;

namespace BuildingSmart.IFC.IfcSharedBldgServiceElements
{
	[Guid("59ccf55f-0899-4232-ba41-1fc821d5fcb5")]
	public partial class IfcSoundValue : IfcPropertySetDefinition
	{
		[DataMember(Order=0)] 
		IfcTimeSeries _SoundLevelTimeSeries;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcFrequencyMeasure _Frequency;
	
		[DataMember(Order=2)] 
		IfcDerivedMeasureValue _SoundLevelSingleValue;
	
	
		[Description(@"A time series of sound pressure or sound power values. For sound pressure levels, the values are measured in decibels at a reference pressure of 20 microPascals for the referenced octave band frequency. For sound power levels, the values are measured in decibels at a reference power of 1 picowatt(10^(-12) watt) for the referenced octave band frequency.")]
		public IfcTimeSeries SoundLevelTimeSeries { get { return this._SoundLevelTimeSeries; } set { this._SoundLevelTimeSeries = value;} }
	
		[Description("The frequency of the sound.")]
		public IfcFrequencyMeasure Frequency { get { return this._Frequency; } set { this._Frequency = value;} }
	
		[Description(@"A sound pressure or sound power value. For sound pressure levels, the values are measured in decibels at a reference pressure of 20 microPascals for the referenced octave band frequency. For sound power levels, the values are measured in decibels at a reference power of 1 picowatt(10^(-12) watt) for the referenced octave band frequency.")]
		public IfcDerivedMeasureValue SoundLevelSingleValue { get { return this._SoundLevelSingleValue; } set { this._SoundLevelSingleValue = value;} }
	
	
	}
	
}