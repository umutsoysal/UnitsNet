//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     The volumetric heat capacity is the amount of energy that must be added, in the form of heat, to one unit of volume of the material in order to cause an increase of one unit in its temperature.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Volumetric_heat_capacity
    /// </remarks>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class VolumetricHeatCapacity : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly VolumetricHeatCapacityUnit? _unit;

        static VolumetricHeatCapacity()
        {
            BaseDimensions = new BaseDimensions(-1, 1, -2, 0, -1, 0, 0);
            BaseUnit = VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin;
            MaxValue = new VolumetricHeatCapacity(double.MaxValue, BaseUnit);
            MinValue = new VolumetricHeatCapacity(double.MinValue, BaseUnit);
            QuantityType = QuantityType.VolumetricHeatCapacity;
            Units = Enum.GetValues(typeof(VolumetricHeatCapacityUnit)).Cast<VolumetricHeatCapacityUnit>().Except(new VolumetricHeatCapacityUnit[]{ VolumetricHeatCapacityUnit.Undefined }).ToArray();
            Zero = new VolumetricHeatCapacity(0, BaseUnit);
            Info = new QuantityInfo(QuantityType.VolumetricHeatCapacity, Units.Cast<Enum>().ToArray(), BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit JoulePerCubicMeterKelvin.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public VolumetricHeatCapacity()
        {
            _value = 0;
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        private VolumetricHeatCapacity(double value, VolumetricHeatCapacityUnit unit)
        {
            if (unit == VolumetricHeatCapacityUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(value, nameof(value));
            _unit = unit;
        }

        #region Static Properties

        /// <summary>
        ///     Information about the quantity type, such as unit values and names.
        /// </summary>
        internal static QuantityInfo Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of VolumetricHeatCapacity, which is JoulePerCubicMeterKelvin. All conversions go via this value.
        /// </summary>
        public static VolumetricHeatCapacityUnit BaseUnit { get; }

        /// <summary>
        /// Represents the largest possible value of VolumetricHeatCapacity
        /// </summary>
        public static VolumetricHeatCapacity MaxValue { get; }

        /// <summary>
        /// Represents the smallest possible value of VolumetricHeatCapacity
        /// </summary>
        public static VolumetricHeatCapacity MinValue { get; }

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public static QuantityType QuantityType { get; }

        /// <summary>
        ///     All units of measurement for the VolumetricHeatCapacity quantity.
        /// </summary>
        public static VolumetricHeatCapacityUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit JoulePerCubicMeterKelvin.
        /// </summary>
        public static VolumetricHeatCapacity Zero { get; }

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => Convert.ToDouble(_value);

        /// <inheritdoc cref="IQuantity.Unit"/>
        object IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public VolumetricHeatCapacityUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public QuantityType Type => VolumetricHeatCapacity.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => VolumetricHeatCapacity.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="VolumetricHeatCapacityUnit.BtuPerCubicFootDegreeFahrenheit"/>
        /// </summary>
        public double BtusPerCubicFootDegreeFahrenheit => As(VolumetricHeatCapacityUnit.BtuPerCubicFootDegreeFahrenheit);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="VolumetricHeatCapacityUnit.CaloriePerCubicCentimeterDegreeCelsius"/>
        /// </summary>
        public double CaloriesPerCubicCentimeterDegreeCelsius => As(VolumetricHeatCapacityUnit.CaloriePerCubicCentimeterDegreeCelsius);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="VolumetricHeatCapacityUnit.JoulePerCubicMeterDegreeCelsius"/>
        /// </summary>
        public double JoulesPerCubicMeterDegreeCelsius => As(VolumetricHeatCapacityUnit.JoulePerCubicMeterDegreeCelsius);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin"/>
        /// </summary>
        public double JoulesPerCubicMeterKelvin => As(VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="VolumetricHeatCapacityUnit.KilocaloriePerCubicCentimeterDegreeCelsius"/>
        /// </summary>
        public double KilocaloriesPerCubicCentimeterDegreeCelsius => As(VolumetricHeatCapacityUnit.KilocaloriePerCubicCentimeterDegreeCelsius);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="VolumetricHeatCapacityUnit.KilojoulePerCubicMeterDegreeCelsius"/>
        /// </summary>
        public double KilojoulesPerCubicMeterDegreeCelsius => As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterDegreeCelsius);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin"/>
        /// </summary>
        public double KilojoulesPerCubicMeterKelvin => As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="VolumetricHeatCapacityUnit.MegajoulePerCubicMeterDegreeCelsius"/>
        /// </summary>
        public double MegajoulesPerCubicMeterDegreeCelsius => As(VolumetricHeatCapacityUnit.MegajoulePerCubicMeterDegreeCelsius);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin"/>
        /// </summary>
        public double MegajoulesPerCubicMeterKelvin => As(VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin);

        #endregion

        #region Static Methods

        internal static void MapGeneratedLocalizations(UnitAbbreviationsCache unitAbbreviationsCache)
        {
            unitAbbreviationsCache.PerformAbbreviationMapping(VolumetricHeatCapacityUnit.BtuPerCubicFootDegreeFahrenheit, new CultureInfo("en-US"), false, true, new string[]{"BTU/ft³·°F"});
            unitAbbreviationsCache.PerformAbbreviationMapping(VolumetricHeatCapacityUnit.CaloriePerCubicCentimeterDegreeCelsius, new CultureInfo("en-US"), false, true, new string[]{"cal/cm³·°C"});
            unitAbbreviationsCache.PerformAbbreviationMapping(VolumetricHeatCapacityUnit.JoulePerCubicMeterDegreeCelsius, new CultureInfo("en-US"), false, true, new string[]{"J/m³·°C"});
            unitAbbreviationsCache.PerformAbbreviationMapping(VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin, new CultureInfo("en-US"), false, true, new string[]{"J/m³·K"});
            unitAbbreviationsCache.PerformAbbreviationMapping(VolumetricHeatCapacityUnit.KilocaloriePerCubicCentimeterDegreeCelsius, new CultureInfo("en-US"), false, true, new string[]{"kcal/cm³·°C"});
            unitAbbreviationsCache.PerformAbbreviationMapping(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterDegreeCelsius, new CultureInfo("en-US"), false, true, new string[]{"kJ/m³·°C"});
            unitAbbreviationsCache.PerformAbbreviationMapping(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin, new CultureInfo("en-US"), false, true, new string[]{"kJ/m³·K"});
            unitAbbreviationsCache.PerformAbbreviationMapping(VolumetricHeatCapacityUnit.MegajoulePerCubicMeterDegreeCelsius, new CultureInfo("en-US"), false, true, new string[]{"MJ/m³·°C"});
            unitAbbreviationsCache.PerformAbbreviationMapping(VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin, new CultureInfo("en-US"), false, true, new string[]{"MJ/m³·K"});
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(VolumetricHeatCapacityUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(VolumetricHeatCapacityUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="VolumetricHeatCapacity"/> from <see cref="VolumetricHeatCapacityUnit.BtuPerCubicFootDegreeFahrenheit"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static VolumetricHeatCapacity FromBtusPerCubicFootDegreeFahrenheit(double btuspercubicfootdegreefahrenheit)
        {
            double value = (double) btuspercubicfootdegreefahrenheit;
            return new VolumetricHeatCapacity(value, VolumetricHeatCapacityUnit.BtuPerCubicFootDegreeFahrenheit);
        }

        /// <summary>
        ///     Creates a <see cref="VolumetricHeatCapacity"/> from <see cref="VolumetricHeatCapacityUnit.CaloriePerCubicCentimeterDegreeCelsius"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static VolumetricHeatCapacity FromCaloriesPerCubicCentimeterDegreeCelsius(double caloriespercubiccentimeterdegreecelsius)
        {
            double value = (double) caloriespercubiccentimeterdegreecelsius;
            return new VolumetricHeatCapacity(value, VolumetricHeatCapacityUnit.CaloriePerCubicCentimeterDegreeCelsius);
        }

        /// <summary>
        ///     Creates a <see cref="VolumetricHeatCapacity"/> from <see cref="VolumetricHeatCapacityUnit.JoulePerCubicMeterDegreeCelsius"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static VolumetricHeatCapacity FromJoulesPerCubicMeterDegreeCelsius(double joulespercubicmeterdegreecelsius)
        {
            double value = (double) joulespercubicmeterdegreecelsius;
            return new VolumetricHeatCapacity(value, VolumetricHeatCapacityUnit.JoulePerCubicMeterDegreeCelsius);
        }

        /// <summary>
        ///     Creates a <see cref="VolumetricHeatCapacity"/> from <see cref="VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static VolumetricHeatCapacity FromJoulesPerCubicMeterKelvin(double joulespercubicmeterkelvin)
        {
            double value = (double) joulespercubicmeterkelvin;
            return new VolumetricHeatCapacity(value, VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin);
        }

        /// <summary>
        ///     Creates a <see cref="VolumetricHeatCapacity"/> from <see cref="VolumetricHeatCapacityUnit.KilocaloriePerCubicCentimeterDegreeCelsius"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static VolumetricHeatCapacity FromKilocaloriesPerCubicCentimeterDegreeCelsius(double kilocaloriespercubiccentimeterdegreecelsius)
        {
            double value = (double) kilocaloriespercubiccentimeterdegreecelsius;
            return new VolumetricHeatCapacity(value, VolumetricHeatCapacityUnit.KilocaloriePerCubicCentimeterDegreeCelsius);
        }

        /// <summary>
        ///     Creates a <see cref="VolumetricHeatCapacity"/> from <see cref="VolumetricHeatCapacityUnit.KilojoulePerCubicMeterDegreeCelsius"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static VolumetricHeatCapacity FromKilojoulesPerCubicMeterDegreeCelsius(double kilojoulespercubicmeterdegreecelsius)
        {
            double value = (double) kilojoulespercubicmeterdegreecelsius;
            return new VolumetricHeatCapacity(value, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterDegreeCelsius);
        }

        /// <summary>
        ///     Creates a <see cref="VolumetricHeatCapacity"/> from <see cref="VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static VolumetricHeatCapacity FromKilojoulesPerCubicMeterKelvin(double kilojoulespercubicmeterkelvin)
        {
            double value = (double) kilojoulespercubicmeterkelvin;
            return new VolumetricHeatCapacity(value, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);
        }

        /// <summary>
        ///     Creates a <see cref="VolumetricHeatCapacity"/> from <see cref="VolumetricHeatCapacityUnit.MegajoulePerCubicMeterDegreeCelsius"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static VolumetricHeatCapacity FromMegajoulesPerCubicMeterDegreeCelsius(double megajoulespercubicmeterdegreecelsius)
        {
            double value = (double) megajoulespercubicmeterdegreecelsius;
            return new VolumetricHeatCapacity(value, VolumetricHeatCapacityUnit.MegajoulePerCubicMeterDegreeCelsius);
        }

        /// <summary>
        ///     Creates a <see cref="VolumetricHeatCapacity"/> from <see cref="VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static VolumetricHeatCapacity FromMegajoulesPerCubicMeterKelvin(double megajoulespercubicmeterkelvin)
        {
            double value = (double) megajoulespercubicmeterkelvin;
            return new VolumetricHeatCapacity(value, VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="VolumetricHeatCapacityUnit" /> to <see cref="VolumetricHeatCapacity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>VolumetricHeatCapacity unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static VolumetricHeatCapacity From(double value, VolumetricHeatCapacityUnit fromUnit)
        {
            return new VolumetricHeatCapacity((double)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static VolumetricHeatCapacity Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static VolumetricHeatCapacity Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<VolumetricHeatCapacity, VolumetricHeatCapacityUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out VolumetricHeatCapacity result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out VolumetricHeatCapacity result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<VolumetricHeatCapacity, VolumetricHeatCapacityUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static VolumetricHeatCapacityUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static VolumetricHeatCapacityUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<VolumetricHeatCapacityUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out VolumetricHeatCapacityUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out VolumetricHeatCapacityUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<VolumetricHeatCapacityUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            if (!(obj is VolumetricHeatCapacity objVolumetricHeatCapacity)) throw new ArgumentException("Expected type VolumetricHeatCapacity.", nameof(obj));

            return CompareTo(objVolumetricHeatCapacity);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(VolumetricHeatCapacity other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is VolumetricHeatCapacity objVolumetricHeatCapacity))
                return false;

            return Equals(objVolumetricHeatCapacity);
        }

        public bool Equals(VolumetricHeatCapacity other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another VolumetricHeatCapacity within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(VolumetricHeatCapacity other, double tolerance, ComparisonType comparisonType)
        {
            if (tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current VolumetricHeatCapacity.</returns>
        public override int GetHashCode()
        {
            return new { Info.Name, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(object unit) => As((VolumetricHeatCapacityUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(VolumetricHeatCapacityUnit unit)
        {
            if (Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this VolumetricHeatCapacity to another VolumetricHeatCapacity with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A VolumetricHeatCapacity with the specified unit.</returns>
        public VolumetricHeatCapacity ToUnit(VolumetricHeatCapacityUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new VolumetricHeatCapacity(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case VolumetricHeatCapacityUnit.BtuPerCubicFootDegreeFahrenheit: return _value / 1.4910660e-5;
                case VolumetricHeatCapacityUnit.CaloriePerCubicCentimeterDegreeCelsius: return _value / 2.388459e-7;
                case VolumetricHeatCapacityUnit.JoulePerCubicMeterDegreeCelsius: return _value;
                case VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin: return _value;
                case VolumetricHeatCapacityUnit.KilocaloriePerCubicCentimeterDegreeCelsius: return (_value / 2.388459e-7) * 1e3d;
                case VolumetricHeatCapacityUnit.KilojoulePerCubicMeterDegreeCelsius: return (_value) * 1e3d;
                case VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin: return (_value) * 1e3d;
                case VolumetricHeatCapacityUnit.MegajoulePerCubicMeterDegreeCelsius: return (_value) * 1e6d;
                case VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin: return (_value) * 1e6d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(VolumetricHeatCapacityUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case VolumetricHeatCapacityUnit.BtuPerCubicFootDegreeFahrenheit: return baseUnitValue * 1.4910660e-5;
                case VolumetricHeatCapacityUnit.CaloriePerCubicCentimeterDegreeCelsius: return baseUnitValue * 2.388459e-7;
                case VolumetricHeatCapacityUnit.JoulePerCubicMeterDegreeCelsius: return baseUnitValue;
                case VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin: return baseUnitValue;
                case VolumetricHeatCapacityUnit.KilocaloriePerCubicCentimeterDegreeCelsius: return (baseUnitValue * 2.388459e-7) / 1e3d;
                case VolumetricHeatCapacityUnit.KilojoulePerCubicMeterDegreeCelsius: return (baseUnitValue) / 1e3d;
                case VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin: return (baseUnitValue) / 1e3d;
                case VolumetricHeatCapacityUnit.MegajoulePerCubicMeterDegreeCelsius: return (baseUnitValue) / 1e6d;
                case VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin: return (baseUnitValue) / 1e6d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName)
        {
            var provider = cultureName;
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString(string cultureName, int significantDigitsAfterRadix)
        {
            var provider = cultureName;
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implicitly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName, [NotNull] string format, [NotNull] params object[] args)
        {
            var provider = GetFormatProviderFromCultureName(cultureName);
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        private static IFormatProvider GetFormatProviderFromCultureName([CanBeNull] string cultureName)
        {
            return cultureName != null ? new CultureInfo(cultureName) : (IFormatProvider)null;
        }
    }
}
