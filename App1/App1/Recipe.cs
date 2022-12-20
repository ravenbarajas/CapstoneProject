using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Ingredients { get; set; }
        public string Instructions { get; set; }
    }
}
