﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServer.Http
{
    public enum HttpStatusCode
    {
        OK = 200,
        Found = 302,
        BadRequest = 400,
        NotFound = 404,
    }
}
