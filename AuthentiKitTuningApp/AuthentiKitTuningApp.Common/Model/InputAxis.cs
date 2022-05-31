﻿using System;
using System.Diagnostics;

namespace MappingManager.Common.Model
{
    public class InputAxis
    {

        public Guid Guid { get; set; } // A unique ID for the device, that persists betweens sessions and unplugging
        public string Device { get; set; } // Name of device
        public int AxisId { get; set; } // Integer button number
        public string Name { get; set; } // Channel name as combination of device and button
        public int Hash { get => this.GetHashCode(); } // Used as a pseudo unique reference for a device and button combo
        public int Min { get; set; } // Minimum calibrated value
        public int Max { get; set; } // Max calibrated value

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 5381;
                if (Device != null)
                {
                    for (int i = 0; i < Device.Length; i++)
                    {
                        hash = hash * 33 + Device[i];
                    }
                    hash = hash * 23 + AxisId;
                }
                return hash;
            }
        }

        override public string ToString()
        {
            return (String.Format("{0}: {1}", Device, Name));
        }
    }
}
