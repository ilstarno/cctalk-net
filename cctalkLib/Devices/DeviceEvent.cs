//Device events for now are only two
//The first when the bill or coin is safe and accepted 
//And the other when is an false bill or any other error recived by the bill acceptor or coin reader

using System;

namespace dk.CctalkLib.Devices
{
	public struct DeviceEvent
	{
		public DeviceEvent(Byte coinCode, Byte errorOrRouteCode)
		{
			CoinCode = coinCode;
			ErrorOrRouteCode = errorOrRouteCode;
		}

		public Byte CoinCode;
		public Byte ErrorOrRouteCode;

		public Boolean IsError { get { return CoinCode == 0; } }
	}
}