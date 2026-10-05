Public Class frmLessonViewer

    ' Form1 sets this before showing the viewer so we know which lesson to load
    Public LessonName As String

    Private currentPage As Integer = 0

    Private pageTitles As String()
    Private pageContents As String()

    Private Sub frmLessonViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = LessonName
        LoadLesson()
        ShowPage()
    End Sub

    Private Sub LoadLesson()

        Select Case LessonName

            Case "Orientation"

                pageTitles = {
                    "Welcome to the Swamp!",
                    "How to Use the Lesson Viewer",
                    "Lessons Covered"
                }

                pageContents = {
                    "Welcome to PF101 - Object Oriented Programming. Grab an onion, because we are going through the layers one lesson at a time." &
                    vbCrLf & vbCrLf &
                    "This application contains the lessons for the course. Use the Lessons menu at the top of the main window to choose a topic.",
                    "Each lesson is shown one page at a time." &
                    vbCrLf & vbCrLf &
                    "Use the Previous and Next buttons to move between pages, and the Back button to return to the main window.",
                    "The lessons in this application are:" &
                    vbCrLf & vbCrLf &
                    "Week 2 - Introduction to Object Oriented Programming" & vbCrLf &
                    "Week 3 - Getting Started with Microsoft Visual Basic.NET" & vbCrLf &
                    "Week 4 - Planning Applications and Designing Interfaces" & vbCrLf &
                    "Week 5 - Data Handling" & vbCrLf &
                    "Week 6 - The Selection and Repetition Structure" & vbCrLf &
                    "Week 7 - Arrays" & vbCrLf &
                    "Week 8 - Working with Controls and Properties"
                }

            Case "Classes and Objects"

                pageTitles = {
                    "Object-Oriented Programming",
                    "Classes and Objects",
                    "Example: Person Class"
                }

                pageContents = {
                    "Visual Basic provides full support for object-oriented programming (OOP), including encapsulation, inheritance, and polymorphism." &
                    vbCrLf & vbCrLf &
                    "OOP makes code more organized, reusable, and maintainable. It enables modular design and helps in building larger applications more efficiently.",
                    "The terms class and object are sometimes used interchangeably, but classes describe the type of objects, while objects are usable instances of classes." &
                    vbCrLf & vbCrLf &
                    "The act of creating an object is called instantiation." &
                    vbCrLf & vbCrLf &
                    "Using the blueprint analogy, a class is a blueprint, and an object is a building made from that blueprint.",
                    "This class describes a person. The Dim statement then creates (instantiates) a Person object and sets its data." &
                    vbCrLf & vbCrLf &
                    "Public Class Person" & vbCrLf &
                    "    Public Name As String" & vbCrLf &
                    "    Public Age As Integer" & vbCrLf &
                    "End Class" &
                    vbCrLf & vbCrLf &
                    "Dim p As New Person()" & vbCrLf &
                    "p.Name = ""Alice""" & vbCrLf &
                    "p.Age = 30"
                }

            Case "Inheritance"

                pageTitles = {
                    "What is Inheritance?",
                    "Key Points About Inheritance",
                    "Example: Animal and Dog"
                }

                pageContents = {
                    "Inheritance is a core concept in OOP that allows a class (called a subclass or derived class) to inherit properties and behaviors (methods) from another class (called a superclass or base class)." &
                    vbCrLf & vbCrLf &
                    "This mechanism promotes code reuse and establishes a hierarchical relationship between classes.",
                    "Reusability: Subclasses can reuse code from the superclass, reducing redundancy." & vbCrLf &
                    "Extensibility: Subclasses can add new attributes or methods or override existing ones." & vbCrLf &
                    "Hierarchical Structure: It models real-world relationships, such as a Car class inheriting from a Vehicle class." &
                    vbCrLf & vbCrLf &
                    "For example, if a superclass Animal has methods like Eat and Sleep, a subclass Dog can inherit these methods and also have additional behaviors like Bark.",
                    "Public Class Animal" & vbCrLf &
                    "    Public Overridable Sub Speak()" & vbCrLf &
                    "        Console.WriteLine(""Animal speaks"")" & vbCrLf &
                    "    End Sub" & vbCrLf &
                    "End Class" & vbCrLf &
                    "" & vbCrLf &
                    "Public Class Dog" & vbCrLf &
                    "    Inherits Animal" & vbCrLf &
                    "    Public Overrides Sub Speak()" & vbCrLf &
                    "        Console.WriteLine(""Dog barks"")" & vbCrLf &
                    "    End Sub" & vbCrLf &
                    "End Class"
                }

            Case "Polymorphism"

                pageTitles = {
                    "What is Polymorphism?",
                    "Example"
                }

                pageContents = {
                    "Polymorphism allows objects of different classes to be treated as instances of a common superclass. A single interface can represent different underlying behaviors." &
                    vbCrLf & vbCrLf &
                    "It can be achieved through method overriding, where a subclass provides its own implementation of a method defined in its superclass, or through method overloading, where multiple methods share the same name but differ in parameters." &
                    vbCrLf & vbCrLf &
                    "It is essential for designing systems that are modular, maintainable, and scalable.",
                    "An Animal variable can hold a Dog object. The Dog version of Speak runs." &
                    vbCrLf & vbCrLf &
                    "Dim a As Animal = New Dog()" & vbCrLf &
                    "a.Speak()  ' Outputs: Dog barks"
                }

            Case "Interfaces"

                pageTitles = {
                    "What is an Interface?",
                    "Example: IPrintable"
                }

                pageContents = {
                    "An interface defines a contract that classes can implement. It specifies a set of methods, properties, events, or indexers that implementing classes must provide, without providing the actual implementation itself." &
                    vbCrLf & vbCrLf &
                    "This allows a form of abstraction and promotes loose coupling in your code.",
                    "Public Interface IPrintable" & vbCrLf &
                    "    Sub Print()" & vbCrLf &
                    "End Interface" & vbCrLf &
                    "" & vbCrLf &
                    "Public Class Document" & vbCrLf &
                    "    Implements IPrintable" & vbCrLf &
                    "    Public Sub Print() Implements IPrintable.Print" & vbCrLf &
                    "        Console.WriteLine(""Printing Document..."")" & vbCrLf &
                    "    End Sub" & vbCrLf &
                    "End Class"
                }

            Case "Computer Programming"

                pageTitles = {
                    "What is Computer Programming?"
                }

                pageContents = {
                    "Computers can only follow instructions." &
                    vbCrLf & vbCrLf &
                    "A computer program is a set of instructions on how to solve a problem or perform a task." &
                    vbCrLf & vbCrLf &
                    "Computer programming is the process of developing and implementing various sets of instructions to enable a computer to do a certain task. These instructions are considered computer programs and help the computer to operate smoothly."
                }

            Case "Programming Languages"

                pageTitles = {
                    "Programming Languages"
                }

                pageContents = {
                    "The steps in an algorithm must be stated in a form the computer understands." & vbCrLf &
                    "The CPU processes a series of 1s and 0s called machine language instructions." & vbCrLf &
                    "This is a tedious and difficult format for people." &
                    vbCrLf & vbCrLf &
                    "Programming languages allow us to use words instead of numbers." &
                    vbCrLf & vbCrLf &
                    "Special software called a compiler converts the programming language statements to machine language instructions."
                }

            Case "What is a Program Made Of?"

                pageTitles = {
                    "Keywords, Operators, and Variables"
                }

                pageContents = {
                    "Keywords (Reserved Words) are words with special meaning that make up a high-level programming language. They cannot be used for any other purpose." &
                    vbCrLf & vbCrLf &
                    "Operators are special symbols that perform various operations on data." &
                    vbCrLf & vbCrLf &
                    "Variables are used to store data in memory and are named by the programmer."
                }

            Case "Syntax and Statements"

                pageTitles = {
                    "Syntax and Statements"
                }

                pageContents = {
                    "Syntax is a set of rules. It is similar to the syntax of a spoken language such as English, but it must be strictly followed. If even a single syntax error appears in a program, it will not compile or execute." &
                    vbCrLf & vbCrLf &
                    "Statements are instructions made up of keywords, variables, and operators. They are called source code, or simply code."
                }

            Case "Procedures and Comments"

                pageTitles = {
                    "Procedures and Comments"
                }

                pageContents = {
                    "A procedure is a set of programming statements that perform a specific task." &
                    vbCrLf & vbCrLf &
                    "Comments (remarks) are ignored when the program runs. They help the human reader understand the purpose of programming statements. In Visual Basic, any statement that begins with an apostrophe (') is a comment." &
                    vbCrLf & vbCrLf &
                    "' This is a comment" & vbCrLf &
                    "MessageBox.Show(""Hello"")"
                }

            Case "Translation of Programming Languages"

                pageTitles = {
                    "Translation of Programming Languages"
                }

                pageContents = {
                    "A translator, or programming language processor, is a computer program that translates a program written in a given programming language into a functionally equivalent program in another computer language (the target language)." &
                    vbCrLf & vbCrLf &
                    "The translation is done without losing the functional or logical structure of the original code."
                }

            Case "Exploring the IDE"

                pageTitles = {
                    "Introduction to the IDE",
                    "Menu Bar and Standard Toolbar",
                    "Toolbox",
                    "Solution Explorer",
                    "Properties Window and Form Designer",
                    "Output, Error List, and Command Window",
                    "Managing IDE Windows",
                    "Starting a New Project",
                    "Console Application"
                }

                pageContents = {
                    "An Integrated Development Environment (IDE) provides tools for developing software." &
                    vbCrLf & vbCrLf &
                    "Visual Studio allows developers to write code, design forms, run applications, and find errors.",
                    "The Menu Bar contains commands grouped into menus such as File, Edit, View, Build, and Debug." &
                    vbCrLf & vbCrLf &
                    "The Standard Toolbar provides shortcuts to common commands, such as saving files and starting a project.",
                    "The Toolbox contains controls that you can add to a Windows Form." &
                    vbCrLf & vbCrLf &
                    "Examples include Labels, Buttons, TextBoxes, CheckBoxes, and ComboBoxes." &
                    vbCrLf & vbCrLf &
                    "Drag a control from the Toolbox onto the Form Designer to use it.",
                    "Solution Explorer displays the files and items in your project." &
                    vbCrLf & vbCrLf &
                    "You can use it to open forms, view code files, and organize project items.",
                    "The Properties Window displays the properties of the selected form or control." &
                    vbCrLf & vbCrLf &
                    "You can change properties such as Name, Text, Size, Font, and BackColor." &
                    vbCrLf & vbCrLf &
                    "The Form Designer lets you visually arrange controls on a Windows Form.",
                    "The Output window displays messages produced by Visual Studio during operations such as building a project." &
                    vbCrLf & vbCrLf &
                    "The Error List shows reported errors and warnings that can help you troubleshoot your application." &
                    vbCrLf & vbCrLf &
                    "The Command window can execute supported Visual Studio commands.",
                    "IDE windows can be docked, meaning they are attached to a position in the Visual Studio workspace." &
                    vbCrLf & vbCrLf &
                    "Floating windows can be moved independently." &
                    vbCrLf & vbCrLf &
                    "Auto Hide allows certain tool windows to collapse to the edge of the workspace. ToolTips display brief information when you hover over supported items.",
                    "To create a new project, select File > New > Project." &
                    vbCrLf & vbCrLf &
                    "Choose the appropriate project template, such as a Visual Basic Windows Forms App or Console App." &
                    vbCrLf & vbCrLf &
                    "Enter a project name, choose a location, and follow the prompts to create the project." &
                    vbCrLf & vbCrLf &
                    "The exact template names may vary depending on your Visual Studio version.",
                    "A Console Application displays text in a console window instead of using a graphical Windows Form." &
                    vbCrLf & vbCrLf &
                    "To create one, start a new project and select a Visual Basic Console App template." &
                    vbCrLf & vbCrLf &
                    "For example, this statement displays a message:" &
                    vbCrLf & vbCrLf &
                    "Console.WriteLine(""Hello, World!"")" &
                    vbCrLf & vbCrLf &
                    "Run the project to see the output in the console."
                }

            Case "VB.NET Basic Controls"

                pageTitles = {
                    "VB.NET Basic Controls",
                    "Control Properties",
                    "Control Methods",
                    "Control Events"
                }

                pageContents = {
                    "An object is a user interface element you create on a Visual Basic form by using a Toolbox control. In fact, the form itself is an object." &
                    vbCrLf & vbCrLf &
                    "Every Visual Basic control consists of three important elements:" &
                    vbCrLf & vbCrLf &
                    "Properties - describe the object" & vbCrLf &
                    "Methods - cause an object to do something" & vbCrLf &
                    "Events - what happens when an object does something",
                    "All Visual Basic objects can be moved, resized, or customized by setting their properties. A property is a value or characteristic held by an object, such as Text or ForeColor." &
                    vbCrLf & vbCrLf &
                    "Properties can be set at design time using the Properties window, or at run time using statements in the code." &
                    vbCrLf & vbCrLf &
                    "Object.Property = Value" & vbCrLf &
                    "lblTitle.Text = ""Welcome""" &
                    vbCrLf & vbCrLf &
                    "Object is the name of the object you are customizing, Property is the characteristic you want to change, and Value is the new property setting.",
                    "A method is a procedure created as a member of a class. Methods cause an object to do something and are used to access or manipulate the characteristics of an object or a variable." &
                    vbCrLf & vbCrLf &
                    "If you use a control from the Toolbox, you can call any of its public methods. If none of the existing methods can do what you need, you can add a method to a class." &
                    vbCrLf & vbCrLf &
                    "For example, MessageBox has a method named Show:" &
                    vbCrLf & vbCrLf &
                    "MessageBox.Show(""Hello, World"")",
                    "An event is a signal that informs an application that something important has occurred. For example, when a user clicks a control on a form, the form can raise a Click event and call a procedure that handles it." &
                    vbCrLf & vbCrLf &
                    "Events associated with a form include Click, DoubleClick, Close, Load, and Resize."
                }

            Case "Form Load Event"

                pageTitles = {
                    "Form Load Event",
                    "Handles MyBase.Load"
                }

                pageContents = {
                    "This is the default structure of a form Load event handler. Double-click the form in the Form Designer to create it." &
                    vbCrLf & vbCrLf &
                    "Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load" & vbCrLf &
                    "" & vbCrLf &
                    "End Sub",
                    "Handles MyBase.Load means that the Form1_Load procedure handles the Load event." &
                    vbCrLf & vbCrLf &
                    "If you want to initialize some variables or properties, keep that code inside the Form1_Load procedure." &
                    vbCrLf & vbCrLf &
                    "The name of the event handler is Form1_Load by default, but you can change it to follow your own naming convention."
                }

            Case "Common Windows Forms Controls"

                pageTitles = {
                    "Common Controls",
                    "Form Appearance",
                    "Form Properties"
                }

                pageContents = {
                    "The control classes are defined in the System.Windows.Forms namespace. Commonly used controls are:" &
                    vbCrLf & vbCrLf &
                    "Form - the container for all the controls" & vbCrLf &
                    "TextBox - a Windows text box" & vbCrLf &
                    "Label - a standard Windows label" & vbCrLf &
                    "Button - a Windows button" & vbCrLf &
                    "ListBox - displays a list of items" & vbCrLf &
                    "ComboBox - a Windows combo box" & vbCrLf &
                    "RadioButton - one choice from a group" & vbCrLf &
                    "CheckBox - a Windows check box" & vbCrLf &
                    "PictureBox - displays an image" & vbCrLf &
                    "ProgressBar - a Windows progress bar" & vbCrLf &
                    "ScrollBar - a scroll bar" & vbCrLf &
                    "DateTimePicker - select a date and time",
                    "The look of a form is controlled by its properties. You set them in the Properties window." &
                    vbCrLf & vbCrLf &
                    "Text - the title shown in the title bar" & vbCrLf &
                    "BackColor - the background color" & vbCrLf &
                    "ForeColor - the default text color" & vbCrLf &
                    "Font - the default font of the controls" & vbCrLf &
                    "BackgroundImage - a picture behind the controls" & vbCrLf &
                    "FormBorderStyle - the type of border",
                    "These properties control the size, position, and behavior of a form:" &
                    vbCrLf & vbCrLf &
                    "Name - the name used in code" & vbCrLf &
                    "Size - the width and height" & vbCrLf &
                    "StartPosition - where the form first appears" & vbCrLf &
                    "WindowState - Normal, Minimized, or Maximized" & vbCrLf &
                    "MaximizeBox and MinimizeBox - show or hide the title bar buttons" & vbCrLf &
                    "ControlBox - show or hide the whole set of title bar buttons"
                }

            Case "Tab Index"

                pageTitles = {
                    "Setting the Tab Index Property"
                }

                pageContents = {
                    "A tab index can be any valid integer greater than or equal to zero. Lower numbers are earlier in the tab order." &
                    vbCrLf & vbCrLf &
                    "If more than one control on the same parent has the same tab index, the z-order of the controls determines the order." &
                    vbCrLf & vbCrLf &
                    "For a control to be included in the tab order, its TabStop property must be set to True."
                }

            Case "Anchor"

                pageTitles = {
                    "Anchoring",
                    "Try It: Anchoring"
                }

                pageContents = {
                    "Anchor refers to the position a control keeps relative to the edges of the form. A text box anchored to the left edge of a form stays in the same position as the form is resized." &
                    vbCrLf & vbCrLf &
                    "The default is to anchor a control to the Top and Left edges.",
                    "1. Start a new Windows project." & vbCrLf &
                    "2. Add two text boxes to the form and set the MultiLine property of both to True." & vbCrLf &
                    "3. Change the height of the boxes." & vbCrLf &
                    "4. Click TextBox1 and find the Anchor property in the Properties window." & vbCrLf &
                    "5. Click the arrow to open the drop-down box and choose the edges to anchor to."
                }

            Case "Docking"

                pageTitles = {
                    "Docking",
                    "Try It: Docking"
                }

                pageContents = {
                    "Docking is similar to anchoring, but the control fills a certain area of the form. If you dock a control to the left of the form, it stretches to the height of the form, but its width stays the same." &
                    vbCrLf & vbCrLf &
                    "None" & vbCrLf &
                    "Top" & vbCrLf &
                    "Bottom" & vbCrLf &
                    "Left" & vbCrLf &
                    "Right" & vbCrLf &
                    "Fill - the control fills the whole form",
                    "1. Click one of your text boxes." & vbCrLf &
                    "2. Find the Dock property in the Properties window." & vbCrLf &
                    "3. Click the arrow to open the drop-down box." & vbCrLf &
                    "4. Choose where to dock the control and see how it fills that area of the form."
                }

            Case "Variables"

                pageTitles = {
                    "Variables"
                }

                pageContents = {
                    "Variables:" &
                    vbCrLf & vbCrLf &
                    "Provide a means to store data values that are not stored in files." & vbCrLf &
                    "Support the computation of values in formulas and assignment statements." & vbCrLf &
                    "Represent locations in the computer's memory." & vbCrLf &
                    "Are assigned a unique name for reference when writing code." &
                    vbCrLf & vbCrLf &
                    "The stored value of a variable can change (vary) over time."
                }

            Case "Types of Data"

                pageTitles = {
                    "Types of Data",
                    "Choosing a Data Type"
                }

                pageContents = {
                    "VB provides many data types so programmers can optimize the use of memory. Common ones are:" &
                    vbCrLf & vbCrLf &
                    "String - text (characters)" & vbCrLf &
                    "Integer - whole numbers (4 bytes)" & vbCrLf &
                    "Short - small whole numbers (2 bytes)" & vbCrLf &
                    "Long - large whole numbers (8 bytes)" & vbCrLf &
                    "Single - decimal numbers (4 bytes)" & vbCrLf &
                    "Double - decimal numbers (8 bytes)" & vbCrLf &
                    "Decimal - money and exact decimals (16 bytes)" & vbCrLf &
                    "Boolean - True or False" & vbCrLf &
                    "Char - a single character" & vbCrLf &
                    "Date - a date and time",
                    "Most business applications use String, Decimal, Single, and Integer. Examples:" &
                    vbCrLf & vbCrLf &
                    "Customer Name - String" & vbCrLf &
                    "Customer Number - String (numbers not used in computations)" & vbCrLf &
                    "Balance Due - Decimal (used in calculations)" & vbCrLf &
                    "Quantity in Inventory - Integer or Short" & vbCrLf &
                    "Sales Tax Rate - Single or Decimal"
                }

            Case "Naming Rules for Variables and Constants"

                pageTitles = {
                    "Naming Rules for Variables and Constants"
                }

                pageContents = {
                    "You decide what to name variables and constants, but there are technical rules you must follow:" &
                    vbCrLf & vbCrLf &
                    "Names can include letters, digits, and the underscore, but must begin with a letter." & vbCrLf &
                    "Names cannot contain spaces or periods." & vbCrLf &
                    "Names cannot be VB reserved words such as Dim or Const." & vbCrLf &
                    "Names are not case sensitive: TotalInteger and totalinteger are the same." & vbCrLf &
                    "A name can be very long (the limit is 16,383 characters)."
                }

            Case "Declaring Variables"

                pageTitles = {
                    "Declaring Variables",
                    "Declaring More Than One Variable"
                }

                pageContents = {
                    "Declare local variables with the Dim statement. Declare module-level variables with the Private statement." &
                    vbCrLf & vbCrLf &
                    "The Dim statement needs a name and a data type. An initial value is optional." &
                    vbCrLf & vbCrLf &
                    "Dim StudentNameString As String" & vbCrLf &
                    "Dim CountStudentsInteger As Integer" & vbCrLf &
                    "Dim AccountBalanceDecimal As Decimal = 100D",
                    "You can declare more than one variable in a single Dim statement." &
                    vbCrLf & vbCrLf &
                    "Dim StudentNameString, MajorString As String" & vbCrLf &
                    "Dim SubtotalDecimal, TotalDecimal, TaxAmountDueDecimal As Decimal"
                }

            Case "Constants"

                pageTitles = {
                    "Declaring Constants",
                    "Constant Examples",
                    "Data Type Characters"
                }

                pageContents = {
                    "Declare constants with the Const statement. A constant is stored in memory like a variable, but it cannot change its value during program execution, so it must be given an initial value." &
                    vbCrLf & vbCrLf &
                    "VB has two kinds of constants. Intrinsic constants are predefined in VB, such as Color.Red. Named constants are the ones you define with Const.",
                    "Const SALES_TAX_RATE_SINGLE As Single = 0.0725F" & vbCrLf &
                    "Const BIG_STATE_NAME_STRING As String = ""Alaska""" & vbCrLf &
                    "Const MAX_SIZE_INTEGER As Integer = 4000" &
                    vbCrLf & vbCrLf &
                    "Text constants are placed inside double quotes. Numeric constants do not use quotes. Do not include a comma, dollar sign, or other special characters in a numeric value.",
                    "Append one of these characters to a numeric value to show its data type. Without one, a whole number is assumed to be Integer and a fractional value is assumed to be Double." &
                    vbCrLf & vbCrLf &
                    "Decimal - D - 40.45D" & vbCrLf &
                    "Double - R - 12576.877R" & vbCrLf &
                    "Integer - I - 47852I" & vbCrLf &
                    "Long - L - 9888444222L" & vbCrLf &
                    "Short - S - 2588S" & vbCrLf &
                    "Single - F - 0.0725F"
                }

            Case "Scope of Variables and Constants"

                pageTitles = {
                    "Scope of Variables and Constants",
                    "Module-Level and Local Scope"
                }

                pageContents = {
                    "Scope is the visibility and lifetime of a variable or constant. The lifetime is how long the variable exists. There are four levels of scope:" &
                    vbCrLf & vbCrLf &
                    "Namespace - visible in the entire project (Public Shared)" & vbCrLf &
                    "Module level - visible in every procedure of one form (Private)" & vbCrLf &
                    "Local - declared and used in a single procedure (Dim)" & vbCrLf &
                    "Block - visible only in a small part of a procedure",
                    "A module-level variable is created when the form loads and stays in memory until the form is unloaded. Use it when a value is needed by more than one procedure." &
                    vbCrLf & vbCrLf &
                    "A local variable is created each time the procedure runs and is removed at End Sub. Each time you click the button, a new set of local variables is created."
                }

            Case "Converting Output Data Types"

                pageTitles = {
                    "Converting Output Data Types"
                }

                pageContents = {
                    "To display a number in a TextBox, convert it to a string with the ToString method." &
                    vbCrLf & vbCrLf &
                    "N2 gives two decimal places, C2 gives currency with two decimal places, and N0 gives no decimal places." &
                    vbCrLf & vbCrLf &
                    "SubtotalTextBox.Text = SubtotalDecimal.ToString(""N2"")" & vbCrLf &
                    "SalesTaxTextBox.Text = SalesTaxDecimal.ToString(""C2"")" & vbCrLf &
                    "QuantityTextBox.Text = QuantityInteger.ToString(""N0"")"
                }

            Case "Implicit Conversion"

                pageTitles = {
                    "Implicit Conversion"
                }

                pageContents = {
                    "Implicit conversion is done automatically by VB when going from a narrower to a wider data type (less memory to more memory). No precision is lost, so there is no danger." &
                    vbCrLf & vbCrLf &
                    "In this example, an Integer (4 bytes) is converted to a Double (8 bytes):" &
                    vbCrLf & vbCrLf &
                    "BiggerNumberDouble = SmallerNumberInteger"
                }

            Case "Explicit Conversion"

                pageTitles = {
                    "Explicit Conversion"
                }

                pageContents = {
                    "Explicit conversion, also called casting, converts between numeric data types that do not support implicit conversion." &
                    vbCrLf & vbCrLf &
                    "Use the Convert method to change one numeric type to another. Fractional values are rounded when converted to integer." &
                    vbCrLf & vbCrLf &
                    "Dim intValue As Integer = Convert.ToInt32(dblValue)" & vbCrLf &
                    "Dim decValue As Decimal = Convert.ToDecimal(dblValue)"
                }

            Case "Parse Method"

                pageTitles = {
                    "Parse Method"
                }

                pageContents = {
                    "Use the Parse method to convert a string, such as the text in a TextBox, to a number." &
                    vbCrLf & vbCrLf &
                    "Dim decPrice As Decimal = Decimal.Parse(txtPrice.Text)" & vbCrLf &
                    "Dim intQuantity As Integer = Integer.Parse(txtQuantity.Text)" &
                    vbCrLf & vbCrLf &
                    "Use Convert to change one type of number to another type of number, and Parse to change text to a number."
                }

            Case "Performing Calculations"

                pageTitles = {
                    "Performing Calculations"
                }

                pageContents = {
                    "VB uses a wider data type when a calculation includes unlike data types, or when it parses the value in a TextBox." &
                    vbCrLf & vbCrLf &
                    "This example produces a Decimal result:" &
                    vbCrLf & vbCrLf &
                    "AverageSaleDecimal = TotalSalesDecimal / CountInteger"
                }

            Case "Arithmetic Operators"

                pageTitles = {
                    "Arithmetic Operators",
                    "Exponentiation"
                }

                pageContents = {
                    "The arithmetic operators are the same as in many other programming languages:" &
                    vbCrLf & vbCrLf &
                    "+  Addition" & vbCrLf &
                    "-  Subtraction" & vbCrLf &
                    "*  Multiplication" & vbCrLf &
                    "/  Division" & vbCrLf &
                    "^  Exponentiation" & vbCrLf &
                    "\  Integer Division" & vbCrLf &
                    "Mod  Modulus Division",
                    "Exponentiation raises a number to the specified power. The result is a Double." &
                    vbCrLf & vbCrLf &
                    "ValueSquaredDouble = NumberDecimal ^ 2" & vbCrLf &
                    "ValueCubedDouble = NumberDecimal ^ 3"
                }

            Case "Integer Division"

                pageTitles = {
                    "Integer Division"
                }

                pageContents = {
                    "Integer division divides one integer by another and leaves an integer result. The remainder, if any, is discarded." &
                    vbCrLf & vbCrLf &
                    "If MinutesInteger is 130, this expression returns 2 hours:" &
                    vbCrLf & vbCrLf &
                    "HoursInteger = MinutesInteger \ 60"
                }

            Case "Modulus Division"

                pageTitles = {
                    "Modulus Division"
                }

                pageContents = {
                    "Modulus division returns the remainder of a division operation." &
                    vbCrLf & vbCrLf &
                    "If MinutesInteger is 500, this expression returns 20 minutes. It can be used to calculate the overtime worked in an 8-hour day." &
                    vbCrLf & vbCrLf &
                    "MinutesInteger = MinutesInteger Mod 60"
                }

            Case "Order of Precedence"

                pageTitles = {
                    "Order of Precedence"
                }

                pageContents = {
                    "For expressions that have more than one operation, evaluate in this order:" &
                    vbCrLf & vbCrLf &
                    "(1) Values enclosed inside parentheses" & vbCrLf &
                    "(2) Exponentiation" & vbCrLf &
                    "(3) Multiplication and Division" & vbCrLf &
                    "(4) Integer Division" & vbCrLf &
                    "(5) Modulus Division" & vbCrLf &
                    "(6) Addition and Subtraction"
                }

            Case "Assignment Operators and Formulas"

                pageTitles = {
                    "Assignment Operators and Formulas",
                    "+= and -="
                }

                pageContents = {
                    "The equal sign is the assignment operator. It stores the value of the expression on the right side into the variable on the left side." &
                    vbCrLf & vbCrLf &
                    "ItemValueDecimal = QuantityInteger * PriceDecimal" & vbCrLf &
                    "HoursWorkedSingle = MinutesWorkedSingle / 60F" & vbCrLf &
                    "NetProfitDecimal = GrossSalesDecimal - CostGoodsSoldDecimal",
                    "The plus symbol combined with the equal sign accumulates a value in a variable. These two lines mean the same thing:" &
                    vbCrLf & vbCrLf &
                    "TotalSalesDecimal += SaleAmountDecimal" & vbCrLf &
                    "TotalSalesDecimal = TotalSalesDecimal + SaleAmountDecimal" &
                    vbCrLf & vbCrLf &
                    "The minus symbol combined with the equal sign counts backwards:" &
                    vbCrLf & vbCrLf &
                    "CountInteger -= 1" & vbCrLf &
                    "CountInteger = CountInteger - 1"
                }

            Case "If Statement"

                pageTitles = {
                    "If Statement"
                }

                pageContents = {
                    "An If statement implements branching logic based on a testable condition." &
                    vbCrLf & vbCrLf &
                    "The True branch corresponds to the keyword Then, and the False branch corresponds to the keyword Else. End If closes the statement. You can code any number of statements inside either branch." &
                    vbCrLf & vbCrLf &
                    "If decSales > 50000 Then" & vbCrLf &
                    "    MessageBox.Show(""You've earned a bonus!"")" & vbCrLf &
                    "End If"
                }

            Case "If...Then...ElseIf"

                pageTitles = {
                    "If...Then...ElseIf"
                }

                pageContents = {
                    "The If...Then...ElseIf statement allows an entire series of possible choices. The first true condition is executed." &
                    vbCrLf & vbCrLf &
                    "If it is very cold Then" & vbCrLf &
                    "    Wear a coat" & vbCrLf &
                    "ElseIf it is chilly Then" & vbCrLf &
                    "    Wear a light jacket" & vbCrLf &
                    "ElseIf it is windy Then" & vbCrLf &
                    "    Wear a windbreaker" & vbCrLf &
                    "ElseIf it is hot Then" & vbCrLf &
                    "    Wear no jacket" & vbCrLf &
                    "End If"
                }

            Case "If...Then...Else"

                pageTitles = {
                    "If...Then...Else",
                    "Rules for the Block If"
                }

                pageContents = {
                    "If the expression is True, the statements between Then and Else are executed. If it is False, the statements between Else and End If are executed." &
                    vbCrLf & vbCrLf &
                    "If <condition> Then" & vbCrLf &
                    "    (condition is true - do these actions)" & vbCrLf &
                    "Else" & vbCrLf &
                    "    (condition is false - do these actions)" & vbCrLf &
                    "End If",
                    "A block If statement must always end with End If." & vbCrLf &
                    "The keyword Then must appear on the same line as If." & vbCrLf &
                    "The keywords Else and End If must appear on lines by themselves." & vbCrLf &
                    "The Else branch is optional. Only use it if there is a False branch." & vbCrLf &
                    "Visual Basic automatically indents 4 spaces inside the True and False branches."
                }

            Case "Relational Operators"

                pageTitles = {
                    "Relational Operators"
                }

                pageContents = {
                    "A relational operator determines if a specific relationship exists between two values. Usually a condition is formed using one." &
                    vbCrLf & vbCrLf &
                    ">   Greater than" & vbCrLf &
                    "<   Less than" & vbCrLf &
                    "=   Equal to" & vbCrLf &
                    "<>  Not equal to" & vbCrLf &
                    ">=  Greater than or equal to" & vbCrLf &
                    "<=  Less than or equal to" &
                    vbCrLf & vbCrLf &
                    "Relational operators are binary, meaning they use two operands, for example: length > width."
                }

            Case "Boolean Expressions"

                pageTitles = {
                    "Boolean Expressions",
                    "Boolean Variables as Flags"
                }

                pageContents = {
                    "Relational operators are used in Boolean expressions, which give a True or False result." &
                    vbCrLf & vbCrLf &
                    "Math operators are evaluated before relational operators. Most programmers use parentheses to make the order clear." &
                    vbCrLf & vbCrLf &
                    "If (intX + intY) > (intA - intB) Then" & vbCrLf &
                    "    lblMessage.Text = ""It is true!""" & vbCrLf &
                    "End If" &
                    vbCrLf & vbCrLf &
                    "Either operand may be a function call:" &
                    vbCrLf & vbCrLf &
                    "If CInt(txtInput.Text) < 100 Then" & vbCrLf &
                    "    lblMessage.Text = ""It is true!""" & vbCrLf &
                    "End If",
                    "A flag is a Boolean variable that signals when some condition exists in the program. Since it is already True or False, no = operator is needed." &
                    vbCrLf & vbCrLf &
                    "If blnQuotaMet Then" & vbCrLf &
                    "    lblMessage.Text = ""You have met your sales quota""" & vbCrLf &
                    "End If"
                }

            Case "Nested If Statements"

                pageTitles = {
                    "Nested If Statements"
                }

                pageContents = {
                    "Any type of statement may be used inside Then, Else, or ElseIf, including other If statements. If statements within If statements create a more complex decision structure called a nested If." &
                    vbCrLf & vbCrLf &
                    "If dblSalary > 30000 Then" & vbCrLf &
                    "    If intYearsOnJob > 2 Then" & vbCrLf &
                    "        lblMessage.Text = ""Applicant qualifies.""" & vbCrLf &
                    "    Else" & vbCrLf &
                    "        lblMessage.Text = ""Applicant does not qualify.""" & vbCrLf &
                    "    End If" & vbCrLf &
                    "Else" & vbCrLf &
                    "    If intYearsOnJob > 5 Then" & vbCrLf &
                    "        lblMessage.Text = ""Applicant qualifies.""" & vbCrLf &
                    "    Else" & vbCrLf &
                    "        lblMessage.Text = ""Applicant does not qualify.""" & vbCrLf &
                    "    End If" & vbCrLf &
                    "End If"
                }

            Case "Select Case"

                pageTitles = {
                    "The Select Case Statement",
                    "Select Case General Format",
                    "Select Case Example"
                }

                pageContents = {
                    "Select Case is similar to If...Then...ElseIf. It performs a series of tests and executes the first true condition." &
                    vbCrLf & vbCrLf &
                    "The difference is that a single test expression is listed once, and the possible values are then listed with their statements. Case Else may be included and runs if none of the values match.",
                    "Select Case TestExpression" & vbCrLf &
                    "    Case ExpressionList" & vbCrLf &
                    "        one or more statements" & vbCrLf &
                    "    Case ExpressionList" & vbCrLf &
                    "        one or more statements" & vbCrLf &
                    "    Case Else" & vbCrLf &
                    "        one or more statements" & vbCrLf &
                    "End Select",
                    "Select Case CInt(txtInput.Text)" & vbCrLf &
                    "    Case 1" & vbCrLf &
                    "        MessageBox.Show(""Day 1 is Monday."")" & vbCrLf &
                    "    Case 2" & vbCrLf &
                    "        MessageBox.Show(""Day 2 is Tuesday."")" & vbCrLf &
                    "    Case 3" & vbCrLf &
                    "        MessageBox.Show(""Day 3 is Wednesday."")" & vbCrLf &
                    "    Case Else" & vbCrLf &
                    "        MessageBox.Show(""That value is invalid."")" & vbCrLf &
                    "End Select"
                }

            Case "Logical Operators"

                pageTitles = {
                    "Logical Operators",
                    "Precedence of Logical Operators"
                }

                pageContents = {
                    "Visual Basic provides logical operators that combine multiple Boolean expressions into a compound expression:" &
                    vbCrLf & vbCrLf &
                    "And - both expressions must be true" & vbCrLf &
                    "Or - one or both expressions must be true" & vbCrLf &
                    "Xor - one but not both must be true" & vbCrLf &
                    "Not - reverses True and False",
                    "Logical operators have an order of precedence, from highest to lowest: Not, And, Or, Xor." &
                    vbCrLf & vbCrLf &
                    "In this statement, x < 0 And y > 100 is evaluated first:" &
                    vbCrLf & vbCrLf &
                    "If x < 0 And y > 100 Or z = 50" &
                    vbCrLf & vbCrLf &
                    "If the Or condition must be evaluated first, use parentheses:" &
                    vbCrLf & vbCrLf &
                    "If x < 0 And (y > 100 Or z = 50)"
                }

            Case "And / AndAlso"

                pageTitles = {
                    "The And Operator",
                    "Short-Circuit Evaluation with AndAlso"
                }

                pageContents = {
                    "The And operator combines two expressions into one. Both expressions must be true for the overall expression to be true." &
                    vbCrLf & vbCrLf &
                    "If intTemperature < 20 And intMinutes > 12 Then" & vbCrLf &
                    "    lblMessage.Text = ""The temperature is in the danger zone.""" & vbCrLf &
                    "End If",
                    "With And, if the first expression is false, the whole expression is false. If there is no need to evaluate the second expression, it can be skipped. This is called short-circuit evaluation, and you get it with the AndAlso operator." &
                    vbCrLf & vbCrLf &
                    "If dblX is less than or equal to zero, CheckValue is not called and Expression is False is displayed:" &
                    vbCrLf & vbCrLf &
                    "If dblX > 0 AndAlso CheckValue(dblX) Then" & vbCrLf &
                    "    lblResult.Text = ""Expression is True""" & vbCrLf &
                    "Else" & vbCrLf &
                    "    lblResult.Text = ""Expression is False""" & vbCrLf &
                    "End If"
                }

            Case "Or / OrElse"

                pageTitles = {
                    "The Or Operator",
                    "Short-Circuit Evaluation with OrElse"
                }

                pageContents = {
                    "The Or operator combines two expressions into one. One or both expressions must be true for the overall expression to be true." &
                    vbCrLf & vbCrLf &
                    "If intTemperature < 20 Or intTemperature > 100 Then" & vbCrLf &
                    "    lblMessage.Text = ""The temperature is in the danger zone.""" & vbCrLf &
                    "End If",
                    "With Or, if the first expression is true, the whole expression is true. If there is no need to evaluate the second expression, it can be skipped by using the OrElse operator." &
                    vbCrLf & vbCrLf &
                    "If dblX is equal to zero, CheckValue is not called and the expression is True:" &
                    vbCrLf & vbCrLf &
                    "If dblX = 0 OrElse CheckValue(dblX) Then" & vbCrLf &
                    "    lblResult.Text = ""Expression is True""" & vbCrLf &
                    "End If"
                }

            Case "Xor"

                pageTitles = {
                    "The Xor Operator"
                }

                pageContents = {
                    "Xor stands for exclusive or. One but not both expressions must be true for the overall expression to be true." &
                    vbCrLf & vbCrLf &
                    "If decTotal > 1000 Xor decAverage > 120 Then" & vbCrLf &
                    "    lblMessage.Text = ""You may try again.""" & vbCrLf &
                    "End If"
                }

            Case "Not"

                pageTitles = {
                    "The Not Operator"
                }

                pageContents = {
                    "The Not operator takes a Boolean expression and reverses its logical value. If the expression is true, Not returns False, and if the expression is false, it returns True." &
                    vbCrLf & vbCrLf &
                    "If Not intTemperature > 100 Then" & vbCrLf &
                    "    lblMessage.Text = ""You are below the maximum temperature.""" & vbCrLf &
                    "End If"
                }

            Case "String Comparison"

                pageTitles = {
                    "Comparing Strings",
                    "How Are Strings Compared?",
                    "Testing for No Input"
                }

                pageContents = {
                    "Relational operators can be used to compare strings and string literals." &
                    vbCrLf & vbCrLf &
                    "If strName1 = strName2 Then" & vbCrLf &
                    "    lblMessage.Text = ""Names are the same""" & vbCrLf &
                    "Else" & vbCrLf &
                    "    lblMessage.Text = ""Names are NOT the same""" & vbCrLf &
                    "End If",
                    "Characters are stored as numeric values. Visual Basic uses Unicode, which represents letters, digits, punctuation, and special characters." &
                    vbCrLf & vbCrLf &
                    "Letters are arranged alphabetically, so the numeric value of A is less than the numeric value of B. The characters of each string are compared one by one until a difference is found.",
                    "The predefined constant String.Empty represents an empty string, which has no characters. It is useful for checking whether the user has entered a required value." &
                    vbCrLf & vbCrLf &
                    "If txtInput.Text = String.Empty Then" & vbCrLf &
                    "    lblMessage.Text = ""Please enter a value""" & vbCrLf &
                    "End If"
                }

            Case "String Methods"

                pageTitles = {
                    "ToUpper and ToLower"
                }

                pageContents = {
                    "The ToUpper method changes lowercase letters to uppercase. The ToLower method changes uppercase letters to lowercase. The original string is not changed." &
                    vbCrLf & vbCrLf &
                    "strBigWord = strLittleWord.ToUpper()" & vbCrLf &
                    "strLittleTown = strBigTown.ToLower()"
                }

            Case "IsNumeric"

                pageTitles = {
                    "The IsNumeric Function"
                }

                pageContents = {
                    "IsNumeric accepts a string as an argument and returns True if the string contains a number. Use it to check whether a value contains numeric data." &
                    vbCrLf & vbCrLf &
                    "strNumber = ""576""" & vbCrLf &
                    "If IsNumeric(strNumber)    ' Returns True" & vbCrLf &
                    "" & vbCrLf &
                    "strNumber = ""123abc""" & vbCrLf &
                    "If IsNumeric(strNumber)    ' Returns False"
                }

            Case "String Length"

                pageTitles = {
                    "String Length"
                }

                pageContents = {
                    "The Length property of the String class returns the number of characters in a string." &
                    vbCrLf & vbCrLf &
                    "Dim strName As String = ""Herman""" & vbCrLf &
                    "Dim intNumChars As Integer" & vbCrLf &
                    "intNumChars = strName.Length    ' 6" &
                    vbCrLf & vbCrLf &
                    "You can also find the length of a control's Text property:" &
                    vbCrLf & vbCrLf &
                    "If txtInput.Text.Length > 20 Then" & vbCrLf &
                    "    lblMessage.Text = ""Please enter no more than 20 characters.""" & vbCrLf &
                    "End If"
                }

            Case "Trimming Strings"

                pageTitles = {
                    "Trimming Strings"
                }

                pageContents = {
                    "Three methods remove spaces from strings:" &
                    vbCrLf & vbCrLf &
                    "TrimStart - removes leading spaces" & vbCrLf &
                    "TrimEnd - removes trailing spaces" & vbCrLf &
                    "Trim - removes leading and trailing spaces" &
                    vbCrLf & vbCrLf &
                    "strGreeting = ""    Hello    """ & vbCrLf &
                    "lblMessage1.Text = strGreeting.TrimStart()    ' ""Hello    """ & vbCrLf &
                    "lblMessage2.Text = strGreeting.TrimEnd()    ' ""    Hello""" & vbCrLf &
                    "lblMessage3.Text = strGreeting.Trim()    ' ""Hello"""
                }

            Case "Do While Loop"

                pageTitles = {
                    "Looping Statements",
                    "The Do While Loop"
                }

                pageContents = {
                    "A repetition structure, or loop, causes one or more statements to repeat. Each repetition is called an iteration." &
                    vbCrLf & vbCrLf &
                    "Visual Basic has three types of loops: Do While, Do Until, and For...Next. They differ in how they control the repetition.",
                    "A Do While loop has a Boolean expression that is tested for True or False, and statements that repeat as long as the expression is true." &
                    vbCrLf & vbCrLf &
                    "Dim intCount As Integer = 0" & vbCrLf &
                    "Do While intCount < 10" & vbCrLf &
                    "    lstOutput.Items.Add(""Hello"")" & vbCrLf &
                    "    intCount += 1" & vbCrLf &
                    "Loop"
                }

            Case "For...Next Loop"

                pageTitles = {
                    "For...Next Loop"
                }

                pageContents = {
                    "A For...Next loop sets a start value, compares it to the end value, runs the body, and adds 1 each time. The loop ends when the counter passes the end value." &
                    vbCrLf & vbCrLf &
                    "For intCount = 0 To 9" & vbCrLf &
                    "    MessageBox.Show(""Hello"")" & vbCrLf &
                    "Next"
                }

            Case "Nested Loops"

                pageTitles = {
                    "Nested Loops"
                }

                pageContents = {
                    "A nested loop is a loop inside another loop. The hands of a clock are a good example: the hour hand makes one revolution for every 60 revolutions of the minute hand." &
                    vbCrLf & vbCrLf &
                    "For intHours = 0 To 23" & vbCrLf &
                    "    lblHours.Text = intHours.ToString()" & vbCrLf &
                    "    For intMinutes = 0 To 59" & vbCrLf &
                    "        lblMinutes.Text = intMinutes.ToString()" & vbCrLf &
                    "        For intSeconds = 0 To 59" & vbCrLf &
                    "            lblSeconds.Text = intSeconds.ToString()" & vbCrLf &
                    "        Next" & vbCrLf &
                    "    Next" & vbCrLf &
                    "Next"
                }

            Case "What is an Array?"

                pageTitles = {
                    "What is an Array?"
                }

                pageContents = {
                    "An array is like a group of variables with a single name. It stores multiple values of the same type." &
                    vbCrLf & vbCrLf &
                    "The variables in an array are called elements. You access an element through a subscript (index)." &
                    vbCrLf & vbCrLf &
                    "A one-dimensional array stores a single set of data. A multidimensional array stores multiple sets."
                }

            Case "Declaring an Array"

                pageTitles = {
                    "Declaring an Array"
                }

                pageContents = {
                    "Dim ArrayName(UpperSubscript) As DataType" & vbCrLf &
                    "Dim intHours(6) As Integer" &
                    vbCrLf & vbCrLf &
                    "intHours has seven elements with subscripts 0 through 6." &
                    vbCrLf & vbCrLf &
                    "Default initialization: Integer elements are 0, Decimal elements are 0.0, and String elements are Nothing."
                }

            Case "Initializing an Array"

                pageTitles = {
                    "Initializing an Array",
                    "Named Constants as Subscripts"
                }

                pageContents = {
                    "An array can be initialized when it is declared. Leave the upper subscript blank and the size is implied." &
                    vbCrLf & vbCrLf &
                    "Dim intNumbers() As Integer = { 2, 4, 6, 8, 10, 12 }",
                    "A named constant may be used as the highest subscript, so the size can be changed in one place." &
                    vbCrLf & vbCrLf &
                    "Const intMAX_SUBSCRIPT As Integer = 100" & vbCrLf &
                    "Dim intArray(intMAX_SUBSCRIPT) As Integer"
                }

            Case "One-Dimensional Array"

                pageTitles = {
                    "One-Dimensional Array",
                    "Looping Through an Array"
                }

                pageContents = {
                    "All values in an array are referenced by the same name. Each element is numbered beginning with zero." &
                    vbCrLf & vbCrLf &
                    "Index:  0  1  2  3  4   5" & vbCrLf &
                    "Value:  2  4  6  8  10  12" &
                    vbCrLf & vbCrLf &
                    "AmountDecimal(3) refers to the 4th element, because arrays start with 0.",
                    "The Length property gives the number of elements. A For...Next loop can visit every element." &
                    vbCrLf & vbCrLf &
                    "For intCount = 0 To intNumbers.Length - 1" & vbCrLf &
                    "    lstOutput.Items.Add(intNumbers(intCount))" & vbCrLf &
                    "Next"
                }

            Case "Two-Dimensional Arrays"

                pageTitles = {
                    "Two-Dimensional Arrays",
                    "Looping Through a Two-Dimensional Array"
                }

                pageContents = {
                    "A two-dimensional array has rows and columns. The first subscript is the row and the second is the column." &
                    vbCrLf & vbCrLf &
                    "Dim dblScores(2, 3) As Double" & vbCrLf &
                    "dblScores(2, 1) = 95",
                    "Use one loop inside another: the outer loop goes through the rows and the inner loop goes through the columns." &
                    vbCrLf & vbCrLf &
                    "For intRow = 0 To 2" & vbCrLf &
                    "    For intCol = 0 To 3" & vbCrLf &
                    "        lstOutput.Items.Add(dblScores(intRow, intCol).ToString())" & vbCrLf &
                    "    Next" & vbCrLf &
                    "Next"
                }

            Case "Three-Dimensional Arrays"

                pageTitles = {
                    "Three-Dimensional Arrays and Beyond"
                }

                pageContents = {
                    "You can create arrays with up to 32 dimensions." &
                    vbCrLf & vbCrLf &
                    "Dim intPages(2, 2, 3) As Decimal" &
                    vbCrLf & vbCrLf &
                    "Arrays with more than three dimensions are difficult to visualize, but useful in some programs. For example, a warehouse array can store a part number by pallet, case, row, and column."
                }

            Case "Functions"

                pageTitles = {
                    "Functions",
                    "Function Example"
                }

                pageContents = {
                    "[AccessSpecifier] Function FunctionName([ParameterList]) As DataType" & vbCrLf &
                    "    [Statements]" & vbCrLf &
                    "End Function" &
                    vbCrLf & vbCrLf &
                    "As DataType states the type of the returned value. The value is returned with a Return statement. Functions can also return non-numeric values.",
                    "Function FullName(ByVal strFirst As String, ByVal strLast As String) As String" & vbCrLf &
                    "    Return strFirst & "" "" & strLast" & vbCrLf &
                    "End Function"
                }

            Case "Procedures and Functions with Arrays"

                pageTitles = {
                    "Procedures and Functions with Arrays"
                }

                pageContents = {
                    "Procedures can store data in an array, display its contents, or sum and average its values. Pass the name of the array as the argument." &
                    vbCrLf & vbCrLf &
                    "Sub DisplaySum(ByVal intArray() As Integer)" & vbCrLf &
                    "    Dim intTotal As Integer = 0" & vbCrLf &
                    "    Dim intCount As Integer" & vbCrLf &
                    "    For intCount = 0 To (intArray.Length - 1)" & vbCrLf &
                    "        intTotal += intArray(intCount)" & vbCrLf &
                    "    Next" & vbCrLf &
                    "    MessageBox.Show(""The total is "" & intTotal.ToString())" & vbCrLf &
                    "End Sub"
                }

            Case "Laboratory Activity"

                pageTitles = {
                    "Laboratory Activity"
                }

                pageContents = {
                    "Create an array program that outputs the months in a ListBox." &
                    vbCrLf & vbCrLf &
                    "If you have no computer or Wi-Fi, you may write it by hand, take a picture, and upload it to your personal folder under midterm."
                }

            Case "Dialog Boxes"

                pageTitles = {
                    "Dialog Boxes",
                    "DialogResult Values",
                    "Dialog Box Controls"
                }

                pageContents = {
                    "Windows Forms has built-in dialog boxes for tasks like opening and saving files, printing, and choosing colors and fonts. They reduce the developer's time and workload." &
                    vbCrLf & vbCrLf &
                    "All dialog box classes inherit from the CommonDialog class. ShowDialog displays the dialog at run time and returns a DialogResult value.",
                    "Abort - the user clicked Abort" & vbCrLf &
                    "Cancel - the user clicked Cancel" & vbCrLf &
                    "Ignore - the user clicked Ignore" & vbCrLf &
                    "No - the user clicked No" & vbCrLf &
                    "None - nothing is returned and the dialog keeps running" & vbCrLf &
                    "OK - the user clicked OK" & vbCrLf &
                    "Retry - the user clicked Retry" & vbCrLf &
                    "Yes - the user clicked Yes",
                    "Dialog controls can be added from the Toolbox. They appear in the component tray at the bottom of the Form Designer, not on the form." &
                    vbCrLf & vbCrLf &
                    "ColorDialog - choose a color" & vbCrLf &
                    "FontDialog - choose a font, size, and color" & vbCrLf &
                    "OpenFileDialog - choose a file to open" & vbCrLf &
                    "SaveFileDialog - choose where to save a file" & vbCrLf &
                    "PrintDialog - choose a printer and what to print"
                }

            Case "ColorDialog"

                pageTitles = {
                    "ColorDialog",
                    "ColorDialog Members",
                    "ColorDialog Example"
                }

                pageContents = {
                    "Displays the available colors and lets the user define custom colors. Its main property is Color, which holds the color the user picked.",
                    "Properties: Color, AllowFullOpen, AnyColor, CustomColors, FullOpen, ShowHelp, SolidColorOnly" & vbCrLf &
                    "Methods: Reset, ShowDialog" & vbCrLf &
                    "Event: HelpRequest",
                    "If ColorDialog1.ShowDialog() = DialogResult.OK Then" & vbCrLf &
                    "    Me.BackColor = ColorDialog1.Color" & vbCrLf &
                    "End If"
                }

            Case "FontDialog"

                pageTitles = {
                    "FontDialog",
                    "FontDialog Members",
                    "FontDialog Example"
                }

                pageContents = {
                    "Lets the user choose a font, font size, and color. It returns Font and Color objects. Set ShowColor to True to show the color choice.",
                    "Properties: Font, Color, ShowColor, FontMustExist, MaxSize, MinSize, ShowApply, ShowEffects, ShowHelp" & vbCrLf &
                    "Methods: Reset, ShowDialog" & vbCrLf &
                    "Events: Apply, HelpRequest",
                    "If FontDialog1.ShowDialog() = DialogResult.OK Then" & vbCrLf &
                    "    Label1.Font = FontDialog1.Font" & vbCrLf &
                    "End If"
                }

            Case "OpenFileDialog"

                pageTitles = {
                    "OpenFileDialog",
                    "OpenFileDialog Members",
                    "OpenFileDialog Example"
                }

                pageContents = {
                    "Prompts the user to open a file. It inherits from the abstract class FileDialog, and the file name the user picks is stored in FileName.",
                    "Properties: FileName, Filter, FilterIndex, InitialDirectory, Multiselect, Title, CheckFileExists" & vbCrLf &
                    "Methods: OpenFile, Reset, ShowDialog",
                    "OpenFileDialog1.Filter = ""Text Files|*.txt|All Files|*.*""" & vbCrLf &
                    "If OpenFileDialog1.ShowDialog() = DialogResult.OK Then" & vbCrLf &
                    "    Label1.Text = OpenFileDialog1.FileName" & vbCrLf &
                    "End If"
                }

            Case "SaveFileDialog"

                pageTitles = {
                    "SaveFileDialog",
                    "SaveFileDialog Members",
                    "SaveFileDialog Example"
                }

                pageContents = {
                    "Prompts the user to select a location and a file name for saving a file. It also inherits from FileDialog.",
                    "Properties: FileName, Filter, DefaultExt, InitialDirectory, OverwritePrompt, CreatePrompt, Title" & vbCrLf &
                    "Methods: OpenFile, Reset, ShowDialog",
                    "If SaveFileDialog1.ShowDialog() = DialogResult.OK Then" & vbCrLf &
                    "    Label1.Text = SaveFileDialog1.FileName" & vbCrLf &
                    "End If"
                }

            Case Else

                pageTitles = {"Coming Soon"}
                pageContents = {"This lesson has no content yet."}

        End Select

    End Sub

    Private Sub ShowPage()

        lblTitle.Text = pageTitles(currentPage)
        rtbContent.Text = pageContents(currentPage)
        lblPageNumber.Text = "Page " & (currentPage + 1).ToString() &
                             " of " & pageTitles.Length.ToString()

        btnPrevious.Enabled = (currentPage > 0)
        btnNext.Enabled = (currentPage < pageTitles.Length - 1)

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        If currentPage > 0 Then
            currentPage -= 1
            ShowPage()
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If currentPage < pageTitles.Length - 1 Then
            currentPage += 1
            ShowPage()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class