﻿using JobApplicationManager.Core.Models;

namespace JobApplicationManager.Core.Contracts.Services;

// Remove this class once your pages/features are using your data.
public interface ISampleDataService
{
    Task<IEnumerable<SampleOrder>> GetGridDataAsync();

    Task<IEnumerable<SampleOrder>> GetListDetailsDataAsync();
}
