namespace OmniXaml.Tests.XmlParserTests
{
    using System.Collections.Generic;
    using Model;
    using Xunit;
    
    public class NamescopeTests : XamlToTreeParserTestsBase
    {
        [Fact]
        public void Namescope()
        {
            var parseResult = ParseResult(@"<Window xmlns:x=""special"" xmlns=""root""><TextBlock x:Name=""One"" /></Window>");
            var expectedNode = new ConstructionNode(typeof(Window))
            {
                Assignments = new List<MemberAssignment>
                {
                    new MemberAssignment
                    {
                        Member = Member.FromStandard<Window>(w => w.Content),
                        Children = new List<ConstructionNode>
                        {
                            new ConstructionNode(typeof(TextBlock))
                            {
                                Name = "One",
                                Assignments = new[] {new MemberAssignment {Member = Member.FromStandard<TextBlock>(block => block.Name), SourceValue = "One"}}
                            }
                        }
                    }
                }
            };

            Assert.Equal(expectedNode, parseResult.Root);            
        }
    }
}