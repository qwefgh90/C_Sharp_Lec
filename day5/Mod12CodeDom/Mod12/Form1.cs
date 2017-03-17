using Microsoft.CSharp;
using System;
using System.CodeDom;//<==
using System.CodeDom.Compiler;//<===
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var unit = new CodeCompileUnit();
            var dynamucNamespace = new CodeNamespace("FourthCoffee.Dynamic");
            unit.Namespaces.Add(dynamucNamespace);
            dynamucNamespace.Imports.Add(new CodeNamespaceImport("System"));

            var programType = new CodeTypeDeclaration("Program");
            dynamucNamespace.Types.Add(programType);
            var mainMethod = new CodeEntryPointMethod();
            programType.Members.Add(mainMethod);
            var expression = new CodeMethodInvokeExpression
                (new CodeTypeReferenceExpression("Console"), "WriteLine",
                new CodePrimitiveExpression("Hello Development Team!!!"));
            mainMethod.Statements.Add(expression);

            var provider = new CSharpCodeProvider();
            var filename = "program.cs";
            var stream = new StreamWriter(filename);
            var textWriter = new IndentedTextWriter(stream);
            var options = new CodeGeneratorOptions();
            options.BlankLinesBetweenMembers = true;
         //   var compileUnit = FourthCoffee.GetModel();
           
            provider.GenerateCodeFromCompileUnit(unit, textWriter, options);
            textWriter.Close();
            stream.Close();
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var provider = new CSharpCodeProvider();
            var compilerSetting = new CompilerParameters();
            compilerSetting.ReferencedAssemblies.Add("System.dll");
            compilerSetting.GenerateExecutable = true;
            compilerSetting .OutputAssembly ="FourthCoffee.exe";

            var sourceCodeFileName="program.cs";
            var compilationResults = provider .CompileAssemblyFromFile (compilerSetting ,sourceCodeFileName );

            var buildFailed = false;
            foreach (var error in compilationResults.Errors)
            {
                var errorMessage = error.ToString ();
                buildFailed = true;
            }
        }
    }
}
