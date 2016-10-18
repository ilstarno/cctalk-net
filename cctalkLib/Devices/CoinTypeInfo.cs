using System;

namespace dk.CctalkLib.Devices
{
	public class CoinTypeInfo
	{

        //coin or bill contains two values such as name and the decimal 
       
        public CoinTypeInfo(String name, Decimal value)
		{
			Name = name;
			Value = value;
		}

		public String Name { get; private set; }
		public Decimal Value { get; private set; }

	}
}