using Store.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext context;
        private Random random;

        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Products.Any())
            {
                this.AddProduct("Electro Bomba 4SB 2/26 1HP 400V TURE");
                this.AddProduct("Electro Bomba 4SB 4/18 1.5HP 250V PEDROLLO");
                this.AddProduct("Electro Bomba 4SB 8/16 3HP 400V FRANKLIN");
                this.AddProduct("ELECTROBOMBA PKm 60 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 61 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 62 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 63 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 64 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 65 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 66 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 67 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 68 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 69 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 70 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 71 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 72 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 73 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 74 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 75 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 76 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 77 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 78 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 79 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 80 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 81 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 82 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 83 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 84 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 85 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 86 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 87 0,5 240");
                this.AddProduct("ELECTROBOMBA PKm 88 0,5 240");


                await this.context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name)
        {
            this.context.Products.Add(new Product
            {
                Name = name,
                Price = this.random.Next(200),
                IsAvailable = true,
                Stock = this.random.Next(100)
            });
        }
    }
}
