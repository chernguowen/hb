﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPublish.Model.Request
{
   public class AddComments
    {
        public int NewsId { get; set; }
        public string Contents { get; set; }
    }
}
