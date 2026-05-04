using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public  class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        { 
           int copiaValor = originalValue;
           copiaValor++;
           Product copiaProducto = product;
           copiaProducto.UpdateDescription("Descripción modificada");
           return $"{originalValue}-{copiaValor}-{product.Description}";
        }

        public class Product
        {
            public string Description { get; private set; }
            public Product(string description)
            {
                Description = description;
            }
            public void UpdateDescription(string newDescription)
            {
                Description = newDescription;
            }
        }
    }
}
