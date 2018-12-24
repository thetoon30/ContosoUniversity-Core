using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models.ResponseMessage
{
    public class ResponseBase
    {
        public string userMessage { get; set; }
        public string devMessage { get; set; }
        public int statusCode { get; set; }
    }

    public class ResponseBase<T> where T : class
    {
        public string userMessage { get; set; }
        public string devMessage { get; set; }
        public int statusCode { get; set; }
        public T item { get; set; }
    }
}
