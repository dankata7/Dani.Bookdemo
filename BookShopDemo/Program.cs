using BookShopDemo.Data;
using System;

namespace BookShopDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            var context = new BookShopSchoolContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}