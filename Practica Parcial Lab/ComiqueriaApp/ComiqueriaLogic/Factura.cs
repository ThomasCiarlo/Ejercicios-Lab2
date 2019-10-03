using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;

namespace ComprobantesLogic
{
    public class Factura : Comprobante
    {
        private DateTime fechaVencimiento;
        private TipoFactura tipoFactura;

        public enum TipoFactura { A, B, C, E }

        public Factura(Venta venta, int diasParaVencimiento, TipoFactura tipo): base(venta) {

            base.fechaEmision = DateTime.Now;
            this.fechaVencimiento = DateTime.Now.AddDays(Convert.ToDouble(diasParaVencimiento));
            this.tipoFactura = tipo;
        }

        public Factura(Venta venta, TipoFactura tipo) : this(venta, 15, tipo) { }

        public override string GenerarComprobante()
        {
            Producto p = (Producto)base.Venta;
            StringBuilder texto = new StringBuilder();
            texto.Append($"FACTURA: {this.tipoFactura}\n");
            texto.Append($"Fecha Emisión: {base.fechaEmision}\n");
            texto.Append($"Fecha Vencimiento: {this.fechaVencimiento}\n");
            texto.Append($"Producto: {base.Venta.ObtenerBreveDescripcion()}\n");
            texto.Append($"Cantidad: {base.Venta.Cantidad}\n");
            texto.Append($"Precio Unitario: ${((Producto)base.Venta).Precio}\n");
            texto.Append($"Subtotal: ${ ((Producto)base.Venta).Precio}\n ");
            texto.Append($"Importe IVA: ${p.Precio * 21 / 100}\n");
            texto.Append($"Importe Total: ${Venta.CalcularPrecioFinal(p.Precio,base.Venta.Cantidad)}\n");

            return texto.ToString();
        }
    }
}
