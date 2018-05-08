using System;

namespace ComicsApp.Models
{
    public class Comic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateRelease { get; set; }
        public int Price { get; set; }
    }
}
