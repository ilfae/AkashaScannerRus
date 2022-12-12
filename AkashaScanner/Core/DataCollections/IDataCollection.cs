﻿using System;
using System.Threading.Tasks;

namespace AkashaScanner.Core.DataCollections
{
    public interface IDataCollection
    {
        bool HasLocal();
        bool IsLoaded();
        DateTime GetLastUpdate();
        Task LoadLocal();
        Task LoadRemote();
    }
}
