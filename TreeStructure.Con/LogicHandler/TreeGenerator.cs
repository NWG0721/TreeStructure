using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TreeStructure.Con.TreeEntity;

namespace TreeStructure.Con.LogicHandler
{
	public class TreeGenerator
	{
		public static Tree CreateNewRoot()
		{

			Tree tree = new Tree();

			tree.Root = 0;

			tree.Nodes = CreateNodes();

			return tree;
		}


		public static List<Node> CreateNodes()
		{
			List<Node> nodes = new List<Node>();
			List<Node> childernCollector = new List<Node>();
			Node node = new Node();
			Random random = new Random();
			// For make a level
			int levles = random.Next(2, 10);
			int power;
			for (int i = levles; i >= 0; i--)
			{
				power = Convert.ToInt32(Math.Pow(2, i));
				for (int j = power; j > 0; j--)
				{
					//creating a node
					node = new Node();
					//adding Id to a node
					node.NodeId = power*2;
					if (i == levles)
					{
						node.children = null;
					}
					else
					{
						for (int k = power*2; k > 0; k += 2)
						{
							node.children = new List<int>() { k,k + 1 };
						}
					}
					// adding data to a node
					node.Data = power*2;
					nodes.Add(node);
				}

			}

			return nodes;
		}


		public static void PlantTheTree(Tree tree)
		{

			#region The Test print format

			// ┌┐└┘├┤┬┴┼─│
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write(" ┌───────┤ ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Tree");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(" │");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(" └───┐");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(" │");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(" │");

			#endregion


		}
	}
}
/*
	0 => Root
	1 =>  1 - 2 
	2 =>  3 - 4 - 5 - 6
	3 =>  7 - 8 - 9 - 10 - 11 - 12 - 13 - 14
	4 =>  15 - 16 - 17 - 18 - 19 - 20 - 21 - 22 - 23 - 24 - 25 - 26 - 27 - 28 - 29 - 30 - 31 - 32

	1 - 2 - 3 - 4 - 5 - 6 -  ... - 30 - 31 - 32

 */