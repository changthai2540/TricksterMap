﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace md3_2.Data
{
    public class ConfigLayer
    {
        /// <summary>
        /// The layer's type
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// The layer's X size
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// The layer's Y size
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// The layer's X BPP (bits per pixel)
        /// Probably 0x10/16bpp
        /// </summary>
        public int BppX { get; set; }

        /// <summary>
        /// The layer's Y BPP (bits per pixel)
        /// Probably 0x10/16bpp
        /// </summary>
        public int BppY { get; set; }

        public string GetTypeName()
        {
            switch(Type)
            {
                case 0x1:
                    // Setting where players can walk and where they can't
                    return "Collision Data";
                case 0x2:
                    // Example: O/X points at Paradise
                    return "Special Effects";
                case 0x3:
                    // Soil value?
                    return "Ground Type";
                case 0x4:
                    // Setting height differences?
                    return "Height Data";
            }

            return "Unknown (" + Type + ")";
        }

        public string GetValueName(byte b)
        {
            switch(b)
            {
                case 0:
                    return "Walkable";
                case 1:
                    return "Not Walkable";
            }

            return "Unknown (" + (int)b + ")";
        }
    }
}