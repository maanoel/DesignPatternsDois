﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDois.Capitulo6
{
  public class MensagemPorAdministrativa : IMensagem
  {
    private string nome;

    public MensagemPorAdministrativa(string nome)
    {
      this.nome = nome;
    }

    public IEnviador Enviador { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Envia()
    {
     
    }

    public string Formata()
    {
      return string.Format("Enviando a mensagem para o adm {0}", nome);
    }
  }
}
