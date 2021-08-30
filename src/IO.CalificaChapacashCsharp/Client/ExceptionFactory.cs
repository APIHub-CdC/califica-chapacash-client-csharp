using System;
using RestSharp;

namespace IO.CalificaChapacashCsharp.Client
{
    public delegate Exception ExceptionFactory(string methodName, IRestResponse response);
}
