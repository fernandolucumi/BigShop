namespace BigShop.Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Response
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public Object Result { get; set; }
    }
}
