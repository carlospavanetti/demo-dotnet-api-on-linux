using System;

namespace linux_demo_api
{
    public class Quote
    {
        public string Symbol { get; set; }

        public string Currency { get; set; }

        public DateTime LastQuote { get; set; }

        public decimal Price { get; set; }
    }
}
