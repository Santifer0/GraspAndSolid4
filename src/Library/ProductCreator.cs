//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class ProductCreator
    {
        public Product product;
        public ProductCreator(string description, double unitCost)
        {
        Product product = new Product(Description,unitCost);
        this.product = product;
        }

        public string Description { get; set; }

        public double UnitCost { get; set; }
    }
}