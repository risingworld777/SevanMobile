﻿using System.Collections.Generic;
using System.Threading.Tasks;
using XOCV.Models.ResponseModels;

namespace XOCV.Services
{
    public interface IFtpService
    {
        Task<bool> SendJsonFile(ComplexFormsModel model);
        Task<bool> BackUpAllLocalDataBase(string localDbContent);
		Task<bool> BackUpImages(List<string> imageNames);
    }
}