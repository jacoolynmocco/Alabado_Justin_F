Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click, ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    ' Opens the lesson viewer for the chosen lesson
    Private Sub ShowLesson(lessonName As String)
        Dim viewer As New frmLessonViewer
        viewer.LessonName = lessonName
        viewer.ShowDialog()
    End Sub

    Private Sub OrientationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrientationToolStripMenuItem.Click
        ShowLesson("Orientation")
    End Sub

    Private Sub ClassesAndObjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassesAndObjectsToolStripMenuItem.Click
        ShowLesson("Classes and Objects")
    End Sub

    Private Sub InheritanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InheritanceToolStripMenuItem.Click
        ShowLesson("Inheritance")
    End Sub

    Private Sub PolymorphismToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PolymorphismToolStripMenuItem.Click
        ShowLesson("Polymorphism")
    End Sub

    Private Sub InterfacesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InterfacesToolStripMenuItem.Click
        ShowLesson("Interfaces")
    End Sub

    Private Sub ComputerProgrammingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComputerProgrammingToolStripMenuItem.Click
        ShowLesson("Computer Programming")
    End Sub

    Private Sub ProgrammingLanguagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammingLanguagesToolStripMenuItem.Click
        ShowLesson("Programming Languages")
    End Sub

    Private Sub WhatIsAProgramMadeOfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhatIsAProgramMadeOfToolStripMenuItem.Click
        ShowLesson("What is a Program Made Of?")
    End Sub

    Private Sub SyntaxAndStatementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SyntaxAndStatementsToolStripMenuItem.Click
        ShowLesson("Syntax and Statements")
    End Sub

    Private Sub ProceduresAndCommentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProceduresAndCommentsToolStripMenuItem.Click
        ShowLesson("Procedures and Comments")
    End Sub

    Private Sub TranslationOfProgrammingLanguagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TranslationOfProgrammingLanguagesToolStripMenuItem.Click
        ShowLesson("Translation of Programming Languages")
    End Sub

    Private Sub ExploringTheIDEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExploringTheIDEToolStripMenuItem.Click
        ShowLesson("Exploring the IDE")
    End Sub

    Private Sub VBNetBasicControlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VBNetBasicControlsToolStripMenuItem.Click
        ShowLesson("VB.NET Basic Controls")
    End Sub

    Private Sub FormLoadEventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormLoadEventToolStripMenuItem.Click
        ShowLesson("Form Load Event")
    End Sub

    Private Sub CommonWindowsFormsControlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommonWindowsFormsControlsToolStripMenuItem.Click
        ShowLesson("Common Windows Forms Controls")
    End Sub

    Private Sub TabIndexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabIndexToolStripMenuItem.Click
        ShowLesson("Tab Index")
    End Sub

    Private Sub AnchorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnchorToolStripMenuItem.Click
        ShowLesson("Anchor")
    End Sub

    Private Sub DockingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DockingToolStripMenuItem.Click
        ShowLesson("Docking")
    End Sub

    Private Sub VariablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VariablesToolStripMenuItem.Click
        ShowLesson("Variables")
    End Sub

    Private Sub TypesofDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TypesofDataToolStripMenuItem.Click
        ShowLesson("Types of Data")
    End Sub

    Private Sub NamingRulesforVariablesandConstantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NamingRulesforVariablesandConstantsToolStripMenuItem.Click
        ShowLesson("Naming Rules for Variables and Constants")
    End Sub

    Private Sub DeclaringVariablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeclaringVariablesToolStripMenuItem.Click
        ShowLesson("Declaring Variables")
    End Sub

    Private Sub ConstantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConstantsToolStripMenuItem.Click
        ShowLesson("Constants")
    End Sub

    Private Sub ScopeofVariablesandConstantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScopeofVariablesandConstantsToolStripMenuItem.Click
        ShowLesson("Scope of Variables and Constants")
    End Sub

    Private Sub ConvertingOutputDataTypesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConvertingOutputDataTypesToolStripMenuItem.Click
        ShowLesson("Converting Output Data Types")
    End Sub

    Private Sub ImplicitConversionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImplicitConversionToolStripMenuItem.Click
        ShowLesson("Implicit Conversion")
    End Sub

    Private Sub ExplicitConversionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExplicitConversionToolStripMenuItem.Click
        ShowLesson("Explicit Conversion")
    End Sub

    Private Sub ParseMethodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParseMethodToolStripMenuItem.Click
        ShowLesson("Parse Method")
    End Sub

    Private Sub PerformingCalculationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerformingCalculationsToolStripMenuItem.Click
        ShowLesson("Performing Calculations")
    End Sub

    Private Sub ArithmeticOperatorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArithmeticOperatorsToolStripMenuItem.Click
        ShowLesson("Arithmetic Operators")
    End Sub

    Private Sub IntegerDivisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntegerDivisionToolStripMenuItem.Click
        ShowLesson("Integer Division")
    End Sub

    Private Sub ModulusDivisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModulusDivisionToolStripMenuItem.Click
        ShowLesson("Modulus Division")
    End Sub

    Private Sub OrderofPrecedenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderofPrecedenceToolStripMenuItem.Click
        ShowLesson("Order of Precedence")
    End Sub

    Private Sub AssignmentOperatorsandFormulasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignmentOperatorsandFormulasToolStripMenuItem.Click
        ShowLesson("Assignment Operators and Formulas")
    End Sub

    Private Sub IfStatementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IfStatementToolStripMenuItem.Click
        ShowLesson("If Statement")
    End Sub

    Private Sub IfThenElseIfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IfThenElseIfToolStripMenuItem.Click
        ShowLesson("If...Then...ElseIf")
    End Sub

    Private Sub IfThenElseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IfThenElseToolStripMenuItem.Click
        ShowLesson("If...Then...Else")
    End Sub

    Private Sub RelationalOperatorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelationalOperatorsToolStripMenuItem.Click
        ShowLesson("Relational Operators")
    End Sub

    Private Sub BooleanExpressionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BooleanExpressionsToolStripMenuItem.Click
        ShowLesson("Boolean Expressions")
    End Sub

    Private Sub NestedIfStatementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NestedIfStatementsToolStripMenuItem.Click
        ShowLesson("Nested If Statements")
    End Sub

    Private Sub SelectCaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectCaseToolStripMenuItem.Click
        ShowLesson("Select Case")
    End Sub

    Private Sub LogicalOperatorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogicalOperatorsToolStripMenuItem.Click
        ShowLesson("Logical Operators")
    End Sub

    Private Sub AndAndAlsoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AndAndAlsoToolStripMenuItem.Click
        ShowLesson("And / AndAlso")
    End Sub

    Private Sub OrOrElseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrOrElseToolStripMenuItem.Click
        ShowLesson("Or / OrElse")
    End Sub

    Private Sub XorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XorToolStripMenuItem.Click
        ShowLesson("Xor")
    End Sub

    Private Sub NotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotToolStripMenuItem.Click
        ShowLesson("Not")
    End Sub

    Private Sub StringComparisonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StringComparisonToolStripMenuItem.Click
        ShowLesson("String Comparison")
    End Sub

    Private Sub StringMethodsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StringMethodsToolStripMenuItem.Click
        ShowLesson("String Methods")
    End Sub

    Private Sub IsNumericToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IsNumericToolStripMenuItem.Click
        ShowLesson("IsNumeric")
    End Sub

    Private Sub StringLengthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StringLengthToolStripMenuItem.Click
        ShowLesson("String Length")
    End Sub

    Private Sub TrimmingStringsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrimmingStringsToolStripMenuItem.Click
        ShowLesson("Trimming Strings")
    End Sub

    Private Sub DoWhileLoopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoWhileLoopToolStripMenuItem.Click
        ShowLesson("Do While Loop")
    End Sub

    Private Sub ForNextLoopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForNextLoopToolStripMenuItem.Click
        ShowLesson("For...Next Loop")
    End Sub

    Private Sub NestedLoopsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NestedLoopsToolStripMenuItem.Click
        ShowLesson("Nested Loops")
    End Sub

    Private Sub WhatisanArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhatisanArrayToolStripMenuItem.Click
        ShowLesson("What is an Array?")
    End Sub

    Private Sub DeclaringanArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeclaringanArrayToolStripMenuItem.Click
        ShowLesson("Declaring an Array")
    End Sub

    Private Sub InitializinganArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InitializinganArrayToolStripMenuItem.Click
        ShowLesson("Initializing an Array")
    End Sub

    Private Sub OneDimensionalArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OneDimensionalArrayToolStripMenuItem.Click
        ShowLesson("One-Dimensional Array")
    End Sub

    Private Sub TwoDimensionalArraysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TwoDimensionalArraysToolStripMenuItem.Click
        ShowLesson("Two-Dimensional Arrays")
    End Sub

    Private Sub ThreeDimensionalArraysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThreeDimensionalArraysToolStripMenuItem.Click
        ShowLesson("Three-Dimensional Arrays")
    End Sub

    Private Sub FunctionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunctionsToolStripMenuItem.Click
        ShowLesson("Functions")
    End Sub

    Private Sub ProceduresandFunctionswithArraysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProceduresandFunctionswithArraysToolStripMenuItem.Click
        ShowLesson("Procedures and Functions with Arrays")
    End Sub

    Private Sub LaboratoryActivityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaboratoryActivityToolStripMenuItem.Click
        ShowLesson("Laboratory Activity")
    End Sub

    Private Sub DialogBoxesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DialogBoxesToolStripMenuItem.Click
        ShowLesson("Dialog Boxes")
    End Sub

    Private Sub ColorDialogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorDialogToolStripMenuItem.Click
        ShowLesson("ColorDialog")
    End Sub

    Private Sub FontDialogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontDialogToolStripMenuItem.Click
        ShowLesson("FontDialog")
    End Sub

    Private Sub OpenFileDialogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileDialogToolStripMenuItem.Click
        ShowLesson("OpenFileDialog")
    End Sub

    Private Sub SaveFileDialogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFileDialogToolStripMenuItem.Click
        ShowLesson("SaveFileDialog")
    End Sub

    Private Sub mnuEncapsulation_Click(sender As Object, e As EventArgs) Handles mnuEncapsulation.Click
        Dim frm As New frmEncapsulation
        frm.ShowDialog()
    End Sub

    Private Sub StudentEnrollmentFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentEnrollmentFormToolStripMenuItem.Click
        Dim frm As New frmWorkingWithControls
        frm.ShowDialog()
    End Sub

    Private Sub Level1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Level1ToolStripMenuItem.Click
        Dim frm As New frmLevel1
        frm.ShowDialog()
    End Sub

    Private Sub DevelopingDataDrivenApplicationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DevelopingDataDrivenApplicationToolStripMenuItem1.Click

    End Sub
End Class