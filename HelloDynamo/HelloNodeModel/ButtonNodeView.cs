using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dynamo.Controls;
using Dynamo.Wpf;
using HelloDynamo.HelloNodeModel;

namespace HelloDynamo.HelloNodeModel
{
    public class ButtonNodeView : INodeViewCustomization<ButtonNode>
    {
        public void CustomizeView(ButtonNode model, NodeView nodeView)
        {
            var ui = new Button();//Node name 

            nodeView.inputGrid.Children.Add(ui);
            ui.DataContext = model;
        }

        public void Dispose()
        {
        }
    }
}
