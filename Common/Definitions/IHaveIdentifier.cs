﻿namespace ReactAdminNetCoreServerAPI.Common.Definitions
{
    public interface IHaveIdentifier<TIndentifier>
    {
        TIndentifier Id { get; set; }
    }
}
