﻿using System;

namespace Model.Models
{
    public enum StatusOrder
    {
        New,
        Hold,
        Shipped,
        Delivered,
        Closed
    }
    public enum StatusUser
    {
        New,
        Active,
        Blocked,
        Banned
    }
}