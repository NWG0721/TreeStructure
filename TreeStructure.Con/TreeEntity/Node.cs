using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure.Con.TreeEntity
{
	public class Node
	{
		public int NodeId { get; set; }
		public int Data { get; set; }
		public List<int> children { get; set; } = new List<int>();
	}
}
