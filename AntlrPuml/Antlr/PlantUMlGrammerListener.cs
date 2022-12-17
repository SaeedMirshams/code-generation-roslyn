//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from PlantUMLGrammer.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="PlantUMLGrammerParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public interface IPlantUMLGrammerListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile([NotNull] PlantUMLGrammerParser.FileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile([NotNull] PlantUMLGrammerParser.FileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.namespace_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespace_def([NotNull] PlantUMLGrammerParser.Namespace_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.namespace_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespace_def([NotNull] PlantUMLGrammerParser.Namespace_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.type_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_definition([NotNull] PlantUMLGrammerParser.Type_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.type_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_definition([NotNull] PlantUMLGrammerParser.Type_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.enum_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnum_def([NotNull] PlantUMLGrammerParser.Enum_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.enum_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnum_def([NotNull] PlantUMLGrammerParser.Enum_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.field_def_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterField_def_block([NotNull] PlantUMLGrammerParser.Field_def_blockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.field_def_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitField_def_block([NotNull] PlantUMLGrammerParser.Field_def_blockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.field_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterField_def([NotNull] PlantUMLGrammerParser.Field_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.field_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitField_def([NotNull] PlantUMLGrammerParser.Field_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.enum_field_def_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnum_field_def_block([NotNull] PlantUMLGrammerParser.Enum_field_def_blockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.enum_field_def_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnum_field_def_block([NotNull] PlantUMLGrammerParser.Enum_field_def_blockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.enum_field_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnum_field_def([NotNull] PlantUMLGrammerParser.Enum_field_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.enum_field_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnum_field_def([NotNull] PlantUMLGrammerParser.Enum_field_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.fieldstreotype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldstreotype([NotNull] PlantUMLGrammerParser.FieldstreotypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.fieldstreotype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldstreotype([NotNull] PlantUMLGrammerParser.FieldstreotypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.method_field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethod_field([NotNull] PlantUMLGrammerParser.Method_fieldContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.method_field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethod_field([NotNull] PlantUMLGrammerParser.Method_fieldContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.class_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClass_def([NotNull] PlantUMLGrammerParser.Class_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.class_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClass_def([NotNull] PlantUMLGrammerParser.Class_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.streotype_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStreotype_def([NotNull] PlantUMLGrammerParser.Streotype_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.streotype_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStreotype_def([NotNull] PlantUMLGrammerParser.Streotype_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.streotypename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStreotypename([NotNull] PlantUMLGrammerParser.StreotypenameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.streotypename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStreotypename([NotNull] PlantUMLGrammerParser.StreotypenameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.generic_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeneric_name([NotNull] PlantUMLGrammerParser.Generic_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.generic_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeneric_name([NotNull] PlantUMLGrammerParser.Generic_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.multi_line_comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMulti_line_comment([NotNull] PlantUMLGrammerParser.Multi_line_commentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.multi_line_comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMulti_line_comment([NotNull] PlantUMLGrammerParser.Multi_line_commentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComment([NotNull] PlantUMLGrammerParser.CommentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComment([NotNull] PlantUMLGrammerParser.CommentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.interface_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterface_def([NotNull] PlantUMLGrammerParser.Interface_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.interface_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterface_def([NotNull] PlantUMLGrammerParser.Interface_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.color"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColor([NotNull] PlantUMLGrammerParser.ColorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.color"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColor([NotNull] PlantUMLGrammerParser.ColorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.extrafield"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExtrafield([NotNull] PlantUMLGrammerParser.ExtrafieldContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.extrafield"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExtrafield([NotNull] PlantUMLGrammerParser.ExtrafieldContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.relation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelation([NotNull] PlantUMLGrammerParser.RelationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.relation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelation([NotNull] PlantUMLGrammerParser.RelationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirection([NotNull] PlantUMLGrammerParser.DirectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirection([NotNull] PlantUMLGrammerParser.DirectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.multiplicity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicity([NotNull] PlantUMLGrammerParser.MultiplicityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.multiplicity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicity([NotNull] PlantUMLGrammerParser.MultiplicityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.from"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrom([NotNull] PlantUMLGrammerParser.FromContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.from"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrom([NotNull] PlantUMLGrammerParser.FromContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.to"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTo([NotNull] PlantUMLGrammerParser.ToContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.to"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTo([NotNull] PlantUMLGrammerParser.ToContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.interface_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterface_name([NotNull] PlantUMLGrammerParser.Interface_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.interface_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterface_name([NotNull] PlantUMLGrammerParser.Interface_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.linktext"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLinktext([NotNull] PlantUMLGrammerParser.LinktextContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.linktext"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLinktext([NotNull] PlantUMLGrammerParser.LinktextContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.relationType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelationType([NotNull] PlantUMLGrammerParser.RelationTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.relationType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelationType([NotNull] PlantUMLGrammerParser.RelationTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.accessor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAccessor([NotNull] PlantUMLGrammerParser.AccessorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.accessor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAccessor([NotNull] PlantUMLGrammerParser.AccessorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.fieldName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldName([NotNull] PlantUMLGrammerParser.FieldNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.fieldName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldName([NotNull] PlantUMLGrammerParser.FieldNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.methodName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodName([NotNull] PlantUMLGrammerParser.MethodNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.methodName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodName([NotNull] PlantUMLGrammerParser.MethodNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.ownerClass"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOwnerClass([NotNull] PlantUMLGrammerParser.OwnerClassContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.ownerClass"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOwnerClass([NotNull] PlantUMLGrammerParser.OwnerClassContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.fieldType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldType([NotNull] PlantUMLGrammerParser.FieldTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.fieldType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldType([NotNull] PlantUMLGrammerParser.FieldTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.class_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClass_name([NotNull] PlantUMLGrammerParser.Class_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.class_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClass_name([NotNull] PlantUMLGrammerParser.Class_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.enum_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnum_name([NotNull] PlantUMLGrammerParser.Enum_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.enum_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnum_name([NotNull] PlantUMLGrammerParser.Enum_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.namespace_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespace_name([NotNull] PlantUMLGrammerParser.Namespace_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.namespace_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespace_name([NotNull] PlantUMLGrammerParser.Namespace_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] PlantUMLGrammerParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] PlantUMLGrammerParser.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.dotIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDotIdentifier([NotNull] PlantUMLGrammerParser.DotIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.dotIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDotIdentifier([NotNull] PlantUMLGrammerParser.DotIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.note_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNote_expr([NotNull] PlantUMLGrammerParser.Note_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.note_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNote_expr([NotNull] PlantUMLGrammerParser.Note_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.somethingsToEndNote"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSomethingsToEndNote([NotNull] PlantUMLGrammerParser.SomethingsToEndNoteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.somethingsToEndNote"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSomethingsToEndNote([NotNull] PlantUMLGrammerParser.SomethingsToEndNoteContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlantUMLGrammerParser.somethings"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSomethings([NotNull] PlantUMLGrammerParser.SomethingsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlantUMLGrammerParser.somethings"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSomethings([NotNull] PlantUMLGrammerParser.SomethingsContext context);
}
