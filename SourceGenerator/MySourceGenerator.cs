using System;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace SourceGenerator
{
    [Generator]
    public class MySourceGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            const string source = @"
                namespace GeneratedCode
                {
                    public static class GeneratedClass
                    {
                        public static string TestProperty => ""Hello from generated source!"";
                    }
                }
                ";
            const string desiredFileName = "GeneratedClass.cs";

            // Must specify an encoding here to allow debugging of generated source.
            SourceText sourceText = SourceText.From(source, Encoding.UTF8);
            context.AddSource(desiredFileName, sourceText);
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            throw new NotImplementedException();
        }
    }
}
