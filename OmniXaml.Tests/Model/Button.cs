﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniXaml.Tests.Model
{
    public class Button : ModelObject
    {
        public event EventHandler Click;

        public void ClickButton()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
    }
}
