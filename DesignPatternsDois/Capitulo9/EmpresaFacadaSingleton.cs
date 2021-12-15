namespace DesignPatternsDois.Capitulo9
{
  public class EmpresaFacadaSingleton
  {
    private static EmpresaFacade facade = new EmpresaFacade();

    public EmpresaFacade Instancia
    {
      get
      {
        return facade;
      }
    }
  }
}
