using System;
using System.Collections.Generic;
using System.Linq;

namespace Economy
{
	class Program
	{
		static void Main(string[] args)
		{
			var economyEntities = new List<EconomyEntity>();
		}
	}
  
	public abstract class EconomyEntity
	{
		public List<ResourceProvider> Resources { get; private set; }

		public EconomyEntity()
		{
			Resources = new List<ResourceProvider>();
		}
	}

	public class Worker : EconomyEntity
	{
		public Worker()
		{
			Resources.Add(new ResourceProvider() { Type = Resource.Type.Food, Demand = 1f });
		}	
	}

	public class Factory : EconomyEntity
	{
		public Factory()
		{
			Resources.Add(new ResourceProvider() { Type = Resource.Type.Food, Demand = 1f });
		}	
	}

	public class Resource 
	{
		public enum Type { Money, Food }	
	}

	public class ResourceProvider
	{
		public Resource.Type Type;
		public float Demand;
	}



	
}
