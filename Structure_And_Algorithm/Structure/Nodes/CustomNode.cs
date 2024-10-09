using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Nodes
{
    public class CustomNode<T>
    {
        #region Member Fields
        private T? data;
        protected List<CustomNode<T>?> nodeList;
        #endregion

        #region Properties
        public T? Data { get => data; set => data = value; }
        #endregion

        #region Constructors
        public CustomNode(T? data)
        {
            this.data = data;
            nodeList = new();
        }
        #endregion
    }
}
