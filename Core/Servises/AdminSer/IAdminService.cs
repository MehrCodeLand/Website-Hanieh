﻿using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Servises.AdminSer
{
    public interface IAdminService
    {
        bool CheckPaint(UploadVm upload);
    }
}