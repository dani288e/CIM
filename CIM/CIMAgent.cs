using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Management.Infrastructure;
using CIM.Model;

namespace CIM
{
    public class CimAgent
    {
        CimSession CreateSession(Device device)
        {
            using (CimSession cimsession = CimSession.Create(device.Name))
            {
                return cimsession;
            }
        }


    }
}