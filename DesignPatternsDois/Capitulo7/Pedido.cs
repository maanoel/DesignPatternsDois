using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDois.Capitulo7
{
  class Pedido
  {
    public string Cliente { get; set; }
    public double Valor { get; set; }
    public DateTime DataFinalizacao{ get; set; }
    public Status Status { get; set; }

    public Pedido(string cliente, double valor)
    {
      this.Cliente = cliente;
      this.Valor = valor;
      this.Status = Status.Novo;
    }
  }
}
