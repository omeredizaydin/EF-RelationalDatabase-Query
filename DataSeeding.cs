using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using practiceEntity.Entity;

namespace practiceEntity
{
    public class DataSeeding
    {
        // public static void SeedCountries(DbContext context)
        // {
        //     if(context.Database.GetPendingMigrations().Count()==0)
        //     {
        //         if(context is ShopDbContext)
        //         {
        //             ShopDbContext? _context = context as ShopDbContext;
        //             if(_context?.Products.Count()==0)
        //             {
        //                 _context.Products.AddRange(Products);
        //             }
        //             if(_context?.Categories.Count()==0)
        //             {
        //                 _context.Categories.AddRange(Categories);
        //             }
        //         }
        //     }
        //     context.SaveChanges();
        // }

        // private static Product[] Products =
        // {
        //     new Product(){Name="Samsung S6",Price=3000},
        //     new Product(){Name="Samsung S7",Price=4000},
        //     new Product(){Name="Samsung S8",Price=5000},
        //     new Product(){Name="Samsung S9",Price=6000},
        // };

        //  private static Category[] Categories =
        // {
        //     new Category(){Name="Phone"},
        //     new Category(){Name="Electronics"},
        //     new Category(){Name="Computers"},
        //     new Category(){Name="Grocery"},
        // };
    }
}