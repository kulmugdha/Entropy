﻿using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

public class Startup
{
    public void Configure(IBuilder app)
    {
        app.Run(context =>
        {
            context.Response.ContentType = "text/plain";
            return context.Response.WriteAsync("Hello World");
        });
    }
}
