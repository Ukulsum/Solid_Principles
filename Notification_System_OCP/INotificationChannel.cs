﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_System_OCP
{
    //Start with an interface
    public interface INotificationChannel
    {
        void Send(string message);
    }
}
