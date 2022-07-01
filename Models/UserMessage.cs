﻿using System;

namespace WhosAppClienteBlazor.Models
{
    public class UserMessage
    {
        public string UserName { get; set; }
        public string Message { get; set; }
        public bool CurrentUser { get; set; }
        public DateTime DateSent { get; set; }
    }
}
