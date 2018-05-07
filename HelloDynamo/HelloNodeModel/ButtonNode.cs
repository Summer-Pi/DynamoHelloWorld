using System;
using System.Collections.Generic;
using System.Xml;
using Autodesk.DesignScript.Geometry;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dynamo.Graph.Nodes;
using HelloDynamo.Hello;
using ProtoCore.AST.AssociativeAST;
using Dynamo.UI.Commands;

namespace HelloDynamo.HelloNodeModel
{
    [NodeName("Button")]
    [NodeDescription("Button")]
    [NodeCategory("HelloDynamo")]
/*    [InPortNames("A")]
    [InPortTypes("double")]
    [InPortDescriptions("Number A")]*/
    [OutPortNames("C")]
    [OutPortTypes("double")]
    [OutPortDescriptions("color")]
    [IsDesignScriptCompatible]
    public class ButtonNode :NodeModel
    {
        public ButtonNode()
        {
            RegisterAllPorts();
        }

        public override IEnumerable<AssociativeNode> BuildOutputAst(List<AssociativeNode> inputAstNodes)
        {
           
                return new[] { AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), AstFactory.BuildNullNode()) };
          
        }
    }
}
