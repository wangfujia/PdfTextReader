﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Validator
{
    interface IRunner
    {
        string FilePattern { get; }
        void Run(File file, string outputname);
    }
}
