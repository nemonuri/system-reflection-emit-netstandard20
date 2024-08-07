// <auto-generated>
using System.Reflection;

namespace FxResources.System.Reflection.Emit.NetStandard20
{
    internal static class SR { }
}
namespace System
{
    internal static partial class SR
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(FxResources.System.Reflection.Emit.NetStandard20.SR)));

        /// <summary>Cannot populate assembly metadata multiple times.</summary>
        internal static string @InvalidOperation_CannotPopulateMultipleTimes => GetResourceString("InvalidOperation_CannotPopulateMultipleTimes", @"Cannot populate assembly metadata multiple times.");
        /// <summary>Cannot set parent to an interface.</summary>
        internal static string @Argument_CannotSetParentToInterface => GetResourceString("Argument_CannotSetParentToInterface", @"Cannot set parent to an interface.");
        /// <summary>Interface must be declared abstract.</summary>
        internal static string @InvalidOperation_BadInterfaceNotAbstract => GetResourceString("InvalidOperation_BadInterfaceNotAbstract", @"Interface must be declared abstract.");
        /// <summary>Assembly needs at least one module defined.</summary>
        internal static string @InvalidOperation_AModuleRequired => GetResourceString("InvalidOperation_AModuleRequired", @"Assembly needs at least one module defined.");
        /// <summary>You cannot have more than one dynamic module in each dynamic assembly in this version of the runtime.</summary>
        internal static string @InvalidOperation_NoMultiModuleAssembly => GetResourceString("InvalidOperation_NoMultiModuleAssembly", @"You cannot have more than one dynamic module in each dynamic assembly in this version of the runtime.");
        /// <summary>The invoked member is not supported in a dynamic module.</summary>
        internal static string @NotSupported_DynamicModule => GetResourceString("NotSupported_DynamicModule", @"The invoked member is not supported in a dynamic module.");
        /// <summary>The type code may not be used as a type argument of a custom attribute.</summary>
        internal static string @Argument_InvalidTypeCodeForTypeArgument => GetResourceString("Argument_InvalidTypeCodeForTypeArgument", @"The type code may not be used as a type argument of a custom attribute.");
        /// <summary>'UnmanagedType.{0}' named parameter is only valid for fields.</summary>
        internal static string @NotSupported_UnmanagedTypeOnlyForFields => GetResourceString("NotSupported_UnmanagedTypeOnlyForFields", @"'UnmanagedType.{0}' named parameter is only valid for fields.");
        /// <summary>Custom attribute '{0}' data length is only '{1}'.</summary>
        internal static string @Argument_InvalidCustomAttributeLength => GetResourceString("Argument_InvalidCustomAttributeLength", @"Custom attribute '{0}' data length is only '{1}'.");
        /// <summary>Custom attribute '{0}' prolog invalid.</summary>
        internal static string @Argument_InvalidProlog => GetResourceString("Argument_InvalidProlog", @"Custom attribute '{0}' prolog invalid.");
        /// <summary>Custom attribute '{0}' has unknown named type '{1}'.</summary>
        internal static string @Argument_UnknownNamedType => GetResourceString("Argument_UnknownNamedType", @"Custom attribute '{0}' has unknown named type '{1}'.");
        /// <summary>Type '{0}' not handled in the custom attribute value decoder.</summary>
        internal static string @NotImplemented_TypeForValue => GetResourceString("NotImplemented_TypeForValue", @"Type '{0}' not handled in the custom attribute value decoder.");
        /// <summary>DllName cannot be empty.</summary>
        internal static string @Argument_DllNameCannotBeEmpty => GetResourceString("Argument_DllNameCannotBeEmpty", @"DllName cannot be empty.");
        /// <summary>The specified parameter index is not in range.</summary>
        internal static string @ArgumentOutOfRange_ParamSequence => GetResourceString("ArgumentOutOfRange_ParamSequence", @"The specified parameter index is not in range.");
        /// <summary>Invalid constructor argument {0} provided for MarshalAs atttribute.</summary>
        internal static string @Argument_InvalidArgumentForAttribute => GetResourceString("Argument_InvalidArgumentForAttribute", @"Invalid constructor argument {0} provided for MarshalAs atttribute.");
        /// <summary>Named parameter {0} is not valid for UnmanagedType.{1} type.</summary>
        internal static string @Argument_InvalidParameterForUnmanagedType => GetResourceString("Argument_InvalidParameterForUnmanagedType", @"Named parameter {0} is not valid for UnmanagedType.{1} type.");
        /// <summary>SizeConst parameter must be specified for UnmanagedType.ByValTStr type.</summary>
        internal static string @Argument_SizeConstMustBeSpecified => GetResourceString("Argument_SizeConstMustBeSpecified", @"SizeConst parameter must be specified for UnmanagedType.ByValTStr type.");
        /// <summary>The generic parameters are already defined on this MethodBuilder.</summary>
        internal static string @InvalidOperation_GenericParametersAlreadySet => GetResourceString("InvalidOperation_GenericParametersAlreadySet", @"The generic parameters are already defined on this MethodBuilder.");
        /// <summary>Should only set visibility flags when creating EnumBuilder.</summary>
        internal static string @Argument_ShouldOnlySetVisibilityFlags => GetResourceString("Argument_ShouldOnlySetVisibilityFlags", @"Should only set visibility flags when creating EnumBuilder.");
        /// <summary>Constant does not match the defined type.</summary>
        internal static string @Argument_ConstantDoesntMatch => GetResourceString("Argument_ConstantDoesntMatch", @"Constant does not match the defined type.");
        /// <summary>Null is not a valid constant value for this type.</summary>
        internal static string @Argument_ConstantNull => GetResourceString("Argument_ConstantNull", @"Null is not a valid constant value for this type.");
        /// <summary>Underlying type information on enumeration is not specified.</summary>
        internal static string @InvalidOperation_NoUnderlyingTypeOnEnum => GetResourceString("InvalidOperation_NoUnderlyingTypeOnEnum", @"Underlying type information on enumeration is not specified.");
        /// <summary>Method body should not exist.</summary>
        internal static string @InvalidOperation_ShouldNotHaveMethodBody => GetResourceString("InvalidOperation_ShouldNotHaveMethodBody", @"Method body should not exist.");
        /// <summary>Interface cannot have constructors.</summary>
        internal static string @InvalidOperation_ConstructorNotAllowedOnInterface => GetResourceString("InvalidOperation_ConstructorNotAllowedOnInterface", @"Interface cannot have constructors.");
        /// <summary>Local passed in does not belong to this ILGenerator.</summary>
        internal static string @Argument_UnmatchedMethodForLocal => GetResourceString("Argument_UnmatchedMethodForLocal", @"Local passed in does not belong to this ILGenerator.");
        /// <summary>Invalid Label.</summary>
        internal static string @Argument_InvalidLabel => GetResourceString("Argument_InvalidLabel", @"Invalid Label.");
        /// <summary>Only 'OpCode.Switch' can be used.</summary>
        internal static string @Argument_MustBeSwitchOpCode => GetResourceString("Argument_MustBeSwitchOpCode", @"Only 'OpCode.Switch' can be used.");
        /// <summary>The specified opcode cannot be passed to EmitCall.</summary>
        internal static string @Argument_NotMethodCallOpcode => GetResourceString("Argument_NotMethodCallOpcode", @"The specified opcode cannot be passed to EmitCall.");
        /// <summary>Unable to access ILGenerator on a constructor created with DefineDefaultConstructor.</summary>
        internal static string @InvalidOperation_DefaultConstructorILGen => GetResourceString("InvalidOperation_DefaultConstructorILGen", @"Unable to access ILGenerator on a constructor created with DefineDefaultConstructor.");
        /// <summary>Parent does not have a default constructor. The default constructor must be explicitly defined.</summary>
        internal static string @NotSupported_NoParentDefaultConstructor => GetResourceString("NotSupported_NoParentDefaultConstructor", @"Parent does not have a default constructor. The default constructor must be explicitly defined.");
        /// <summary>Unable to change after type has been created.</summary>
        internal static string @InvalidOperation_TypeHasBeenCreated => GetResourceString("InvalidOperation_TypeHasBeenCreated", @"Unable to change after type has been created.");
        /// <summary>The invoked member is not supported before the type is created.</summary>
        internal static string @NotSupported_TypeNotYetCreated => GetResourceString("NotSupported_TypeNotYetCreated", @"The invoked member is not supported before the type is created.");
        /// <summary>Method cannot be both static and virtual.</summary>
        internal static string @Argument_NoStaticVirtual => GetResourceString("Argument_NoStaticVirtual", @"Method cannot be both static and virtual.");
        /// <summary>Incorrect code generation for exception block.</summary>
        internal static string @Argument_BadExceptionCodeGen => GetResourceString("Argument_BadExceptionCodeGen", @"Incorrect code generation for exception block.");
        /// <summary>Not currently in an exception block.</summary>
        internal static string @Argument_NotInExceptionBlock => GetResourceString("Argument_NotInExceptionBlock", @"Not currently in an exception block.");
        /// <summary>Should not specify exception type for catch clause for filter block.</summary>
        internal static string @Argument_ShouldNotSpecifyExceptionType => GetResourceString("Argument_ShouldNotSpecifyExceptionType", @"Should not specify exception type for catch clause for filter block.");
        /// <summary>{0} is not a GenericMethodDefinition. MakeGenericMethod may only be called on a method for which MethodBase.IsGenericMethodDefinition is true.</summary>
        internal static string @Arg_NotGenericMethodDefinition => GetResourceString("Arg_NotGenericMethodDefinition", @"{0} is not a GenericMethodDefinition. MakeGenericMethod may only be called on a method for which MethodBase.IsGenericMethodDefinition is true.");
        /// <summary>Calling convention must be VarArgs.</summary>
        internal static string @InvalidOperation_NotAVarArgCallingConvention => GetResourceString("InvalidOperation_NotAVarArgCallingConvention", @"Calling convention must be VarArgs.");
        /// <summary>MethodOverride's body must be from this type.</summary>
        internal static string @ArgumentException_BadMethodImplBody => GetResourceString("ArgumentException_BadMethodImplBody", @"MethodOverride's body must be from this type.");
        /// <summary>Method must be called on a Type for which Type.IsGenericParameter is false.</summary>
        internal static string @Argument_GenericParameter => GetResourceString("Argument_GenericParameter", @"Method must be called on a Type for which Type.IsGenericParameter is false.");
        /// <summary>Type '{0}' tried to override method '{1}' but does not implement or inherit that method.</summary>
        internal static string @Argument_InvalidMethodOverride => GetResourceString("Argument_InvalidMethodOverride", @"Type '{0}' tried to override method '{1}' but does not implement or inherit that method.");
        /// <summary>Interface not found.</summary>
        internal static string @Argument_InterfaceNotFound => GetResourceString("Argument_InterfaceNotFound", @"Interface not found.");
        /// <summary>Method '{0}' on type '{1}' is overriding a method that has been overridden.</summary>
        internal static string @Argument_MethodOverriden => GetResourceString("Argument_MethodOverriden", @"Method '{0}' on type '{1}' is overriding a method that has been overridden.");
        /// <summary>Type passed must be an interface.</summary>
        internal static string @Argument_MustBeInterface => GetResourceString("Argument_MustBeInterface", @"Type passed must be an interface.");
        /// <summary>Method '{0}' cannot have a method body</summary>
        internal static string @InvalidOperation_BadMethodBody => GetResourceString("InvalidOperation_BadMethodBody", @"Method '{0}' cannot have a method body");
        /// <summary>Type must be declared abstract if any of its methods are abstract.</summary>
        internal static string @InvalidOperation_BadTypeAttributesNotAbstract => GetResourceString("InvalidOperation_BadTypeAttributesNotAbstract", @"Type must be declared abstract if any of its methods are abstract.");
        /// <summary>Ambiguous match found for '{0} {1}'</summary>
        internal static string @AmbiguousMatch_MemberInfo => GetResourceString("AmbiguousMatch_MemberInfo", @"Ambiguous match found for '{0} {1}'");
        /// <summary>Method '{0}' does not have a method body.</summary>
        internal static string @InvalidOperation_BadEmptyMethodBody => GetResourceString("InvalidOperation_BadEmptyMethodBody", @"Method '{0}' does not have a method body.");
        /// <summary>Label defined multiple times.</summary>
        internal static string @Argument_RedefinedLabel => GetResourceString("Argument_RedefinedLabel", @"Label defined multiple times.");
        /// <summary>PInvoke methods must be static and native and cannot be abstract.</summary>
        internal static string @Argument_BadPInvokeMethod => GetResourceString("Argument_BadPInvokeMethod", @"PInvoke methods must be static and native and cannot be abstract.");
        /// <summary>PInvoke methods cannot exist on interfaces.</summary>
        internal static string @Argument_BadPInvokeOnInterface => GetResourceString("Argument_BadPInvokeOnInterface", @"PInvoke methods cannot exist on interfaces.");
        /// <summary>Method has been already defined.</summary>
        internal static string @Argument_MethodRedefined => GetResourceString("Argument_MethodRedefined", @"Method has been already defined.");
        /// <summary>Global members must be static.</summary>
        internal static string @Argument_GlobalMembersMustBeStatic => GetResourceString("Argument_GlobalMembersMustBeStatic", @"Global members must be static.");
        /// <summary>Type definition of the global function has been completed.</summary>
        internal static string @InvalidOperation_GlobalsHaveBeenCreated => GetResourceString("InvalidOperation_GlobalsHaveBeenCreated", @"Type definition of the global function has been completed.");
        /// <summary>Data size must be &amp;gt; 1 and &amp;lt; 0x3f0000.</summary>
        internal static string @Argument_BadSizeForData => GetResourceString("Argument_BadSizeForData", @"Data size must be &gt; 1 and &lt; 0x3f0000.");
        /// <summary>MetadataToken for the member is not generated until the assembly saved.</summary>
        internal static string @InvalidOperation_TokenNotPopulated => GetResourceString("InvalidOperation_TokenNotPopulated", @"MetadataToken for the member is not generated until the assembly saved.");
        /// <summary>Incorrect signature format.</summary>
        internal static string @Argument_BadSigFormat => GetResourceString("Argument_BadSigFormat", @"Incorrect signature format.");
        /// <summary>Must be an array type.</summary>
        internal static string @Argument_HasToBeArrayClass => GetResourceString("Argument_HasToBeArrayClass", @"Must be an array type.");
        /// <summary>Not supported in a non-reflected type.</summary>
        internal static string @NotSupported_NonReflectedType => GetResourceString("NotSupported_NonReflectedType", @"Not supported in a non-reflected type.");
        /// <summary>Not supported in an array method of a type definition that is not complete.</summary>
        internal static string @NotSupported_SymbolMethod => GetResourceString("NotSupported_SymbolMethod", @"Not supported in an array method of a type definition that is not complete.");
        /// <summary>Invalid source document.</summary>
        internal static string @InvalidOperation_InvalidDocument => GetResourceString("InvalidOperation_InvalidDocument", @"Invalid source document.");
        /// <summary>Unmatching symbol scope.</summary>
        internal static string @InvalidOperation_UnmatchingSymScope => GetResourceString("InvalidOperation_UnmatchingSymScope", @"Unmatching symbol scope.");

    }
}
