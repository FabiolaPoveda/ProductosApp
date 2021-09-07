using System;
using System.Collections.Generic;
using System.Text;
using Domain;
namespace Infraestructure.Productos
{
    class ProductoModel
    {
        private Producto[] productos;

        public void (Producto p)
        {
            Add(p, ref, productos);
        }
        public int Update(Producto p)
        {
            int index = GetIndexById(p);
            if(index < 0)
            {
            throw new Exception($"El producto con Id{p.Id} no se encontró.");
            }

            productos[index] = p;
            return index;
        }
        public bool  Delete(Producto p)
        {
            int index = GetIndexById(p);
            if (index < 0)
            {
                throw new Exception($"El producto con Id{p.Id} no se encontró.");
            }
            if (index != productos.Length - 1)
            {
            productos[index] = Productos[productos.Length - 1];
            }

            Producto[] tmp = new Producto[productos.Length - 1];
            Array.Copy(productos, tmp, tmp.Length - 1);
        }
        public producto[] GetAll()
        {
            return productos;
        }

        #region private method
        public void Add(Producto p, Producto[] pds)
        {
            if(pds == null)
            {
                pds = new Producto[1];
                pds[pds.Length - 1] = p;
                return;
            }
            Producto[] tmp = new Producto[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            pds = tmp;
        }
        private int GetIndexById(Producto p)
        {
            int index = int.MinValue;
                if(productos == null)
                {
                    return index;
                }
            int i = 0;
            foreach(Producto pd in productos)
            {
                if(pd.Id == p.Id)
                {
                    index = i;
                    break;
                }
                i++;
            }
            return index;
        }
        #endregion
    }
}
