﻿using System;


namespace FileExchange.Domain.Enums
{
    [Flags]
    public enum UserStatus
    {
        None = 0,
        Active = 1,
        Blocked = 2
    }
}