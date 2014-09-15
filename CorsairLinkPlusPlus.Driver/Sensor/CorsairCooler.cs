﻿using CorsairLinkPlusPlus.Driver.Node;

namespace CorsairLinkPlusPlus.Driver.Sensor
{
    public class CorsairCooler : CorsairSensor
    {
        internal CorsairCooler(CorsairLinkDevice device, int id)
            : base(device, id)
        {

        }

        public override string GetSensorType()
        {
            return device.GetCoolerType(id);
        }

        public override double GetValue()
        {
            return device.GetCoolerRPM(id);
        }

        public override string GetUnit()
        {
            return "RPM";
        }
    }
}
